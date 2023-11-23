using Koro_Robot_driver;
using System;
using System.Security.Permissions;
using System.Threading;

namespace WaferInspection_System.Squence
{
    class TMMoving : TBaseThread
    {
        Thread thread;
        private new TStep step;

        Alarm_List alarm_List;  // Alarm list

        string Station;

        public TMMoving()
        {
            ModuleName = "TM";
            module = (byte)MODULE._TM;

            alarm_List = new Alarm_List();

            thread = new Thread(new ThreadStart(Execute));
            thread.Start();
        }

        public void Dispose()
        {
            thread.Abort();
        }

        private void Execute()
        {
            try
            {
                while (true)
                {
                    if (Define.Move_Ctrl == "Abort")
                    {
                        AlarmAction("Abort");
                    }
                    else if (Define.Move_Ctrl == "Retry")
                    {
                        AlarmAction("Retry");
                    }

                    if (Define.DryRun_Ctrl == "Abort")
                    {
                        RobotClass.Pause();

                        Define.DryRun_Mode = "Idle";
                        Define.DryRun_Ctrl = "Idle";
                        Define.DryRun_Sts = "Idle";
                    }


                    ManualMovingProgress();

                    DryRunProgress();

                    Thread.Sleep(10);
                }
            }
            catch (Exception)
            {

            }
        }

        private void AlarmAction(string sAction)
        {
            if (sAction == "Abort")
            {
                ActionList();

                Define.Move_Mode = "Idle";
                Define.Move_Ctrl = "Idle";
                Define.Move_Sts = "Idle";

                Global.EventLog("Move has stopped : " + sAction, ModuleName, "Event");
            }
        }

        private void ActionList()
        {
            RobotClass.Pause();
        }

        private void ShowAlarm(string almId)
        {
            ActionList();

            Define.Move_Ctrl = "Alarm";

            // Buzzer IO On.
            Global.SetDigValue((int)DigOutputList.Buzzer_o, (uint)DigitalOffOn.On, ModuleName);

            // Alarm history.
            Define.sAlarmName = "";
            alarm_List.alarm_code = almId;
            Define.sAlarmName = alarm_List.alarm_code;

            Global.EventLog(almId + ":" + Define.sAlarmName, ModuleName, "Alarm");
        }

        public void F_INC_STEP()
        {
            step.Flag = true;
            step.Layer++;
            step.Times = 1;
        }

        // MANUAL MOVING PROGRESS ///////////////////////////////////////////////////////////
        #region MANUAL MOVING PROGRESS
        private void ManualMovingProgress()
        {
            if ((Define.Move_Mode == "Move") && (Define.Move_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.Move_Ctrl = "Running";
                Define.Move_Sts = "MoveIng";

                Global.EventLog(Define.Move_Source + " => " + Define.Move_Target + " MOVING START", ModuleName, "Event");
            }
            else if ((Define.Move_Mode == "Move") && (Define.Move_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            if (step.Flag)
                            {
                                Station = Define.Move_Source;

                                if (Station == "TM")
                                {
                                    F_INC_STEP();
                                    return;
                                }
                                else
                                {
                                    Define.Move_Mode = Station + "Pick";
                                    Define.Move_Ctrl = "Run";
                                    Define.Move_Sts = "Idle";
                                }

                                step.Flag = false;
                                step.Times = 1;
                            }
                            else
                            {
                                if ((Define.Move_Mode == "Idle") && (Define.Move_Ctrl == "Idle") && (Define.Move_Sts != "AbortOK"))
                                {
                                    F_INC_STEP();
                                }
                            }
                        }
                        break;

                    case 2:
                        {
                            if (step.Flag)
                            {
                                Station = Define.Move_Target;

                                if (Station == "TM")
                                {
                                    F_INC_STEP();
                                    return;
                                }
                                else
                                {
                                    Define.Move_Mode = Station + "Place";
                                    Define.Move_Ctrl = "Run";
                                    Define.Move_Sts = "Idle";
                                }

                                step.Flag = false;
                                step.Times = 1;
                            }
                            else
                            {
                                if ((Define.Move_Mode == "Idle") && (Define.Move_Ctrl == "Idle") && (Define.Move_Sts != "AbortOK"))
                                {
                                    F_INC_STEP();
                                }
                            }
                        }
                        break;

                    case 3:
                        {
                            Define.Move_Mode = "Idle";
                            Define.Move_Ctrl = "Idle";
                            Define.Move_Sts = "MoveOK";

                            Global.EventLog(Define.Move_Source + " => " + Define.Move_Target + " MOVING COMPLETED", ModuleName, "Event");
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////        

        private void DryRunProgress()
        {
            if ((Define.DryRun_Mode == "Test") && (Define.DryRun_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.DryRun_Ctrl = "Running";
                Define.DryRun_Sts = "TestIng";                
            }
            else if ((Define.DryRun_Mode == "Test") && (Define.DryRun_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            LP_PICK();
                        }
                        break;

                    case 2:
                        {
                            Aligner_PICK();
                        }
                        break;

                    case 3:
                        {
                            step.Flag = true;
                            step.Layer = 1;
                            step.Times = 1;
                        }
                        break;
                }
            }
        }

        private void LP_PICK()
        {
            if (step.Flag)
            {
                if (RobotClass.robotStatus[0].sR_Busy == "StandBy")
                {
                    RobotClass.Pick(1, 1);
                    Thread.Sleep(1000);

                    step.Flag = false;
                    step.Times = 1;
                }
                else
                {
                    step.Flag = true;
                }                
            }
            else
            {
                if (RobotClass.robotStatus[0].sR_Busy == "Busy")
                {
                    F_INC_STEP();
                }
                else
                {
                    step.INC_TIMES();
                }
            }
        }

        private void Aligner_PICK()
        {
            if (step.Flag)
            {
                if (RobotClass.robotStatus[0].sR_Busy == "StandBy")
                {
                    RobotClass.Pick(2, 1);
                    Thread.Sleep(1000);

                    step.Flag = false;
                    step.Times = 1;
                }
                else
                {
                    step.Flag = true;
                }
            }
            else
            {
                if (RobotClass.robotStatus[0].sR_Busy == "Busy")
                {
                    F_INC_STEP();
                }
                else
                {
                    step.INC_TIMES();
                }
            }
        }
    }
}
