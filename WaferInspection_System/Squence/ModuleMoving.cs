using Koro_Robot_driver;
using System;
using System.Threading;

namespace WaferInspection_System.Squence
{
    class ModuleMoving : TBaseThread
    {
        Thread thread;
        private new TStep step;        
        
        Alarm_List alarm_List;  // Alarm list

        string Station;

        public ModuleMoving()
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
                    if (Define.ModuleMove_Ctrl == "Abort")
                    {
                        AlarmAction("Abort");
                    }
                    else if (Define.ModuleMove_Ctrl == "Retry")
                    {
                        AlarmAction("Retry");
                    }

                    LoadPortPickProgress();
                    LoadPortPlaceProgress();

                    AlignerPickProgress();
                    AlignerPlaceProgress();

                    PMPickProgress();
                    PMPlaceProgress();

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

                Define.ModuleMove_Mode = "Idle";
                Define.ModuleMove_Ctrl = "Idle";
                Define.ModuleMove_Sts = "Idle";

                Global.EventLog("Module move has stopped : " + sAction, ModuleName, "Event");
            }
        }

        private void ActionList()
        {
            RobotClass.Pause();            
        }

        private void ShowAlarm(string almId)
        {
            ActionList();

            Define.ModuleMove_Ctrl = "Alarm";

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

        // LoadPort Pick Progress ///////////////////////////////////////////////////////////
        #region LoadPort Pick Progress
        private void LoadPortPickProgress()
        {
            if ((Define.ModuleMove_Mode == "LoadPortPick") && (Define.ModuleMove_Ctrl == "Run"))
            {                
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "LoadPortPickIng";

                Global.EventLog("LOAD PORT PICK START", ModuleName, "Event");                
            }
            else if ((Define.ModuleMove_Mode == "LoadPortPick") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            MM_Pick("LoadPort");
                        }
                        break;

                    case 2:
                        {
                            //MM_WaferPickInfoSet("LoadPort");
                        }
                        break;

                    case 3:
                        {
                            //MM_Pick_End();
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // LoadPort Place Progress //////////////////////////////////////////////////////////
        #region LoadPort Place Progress
        private void LoadPortPlaceProgress()
        {
            if ((Define.ModuleMove_Mode == "LoadPortPlace") && (Define.ModuleMove_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "LoadPortPlaceIng";

                Global.EventLog("LOAD PORT PLACE START", ModuleName, "Event");
            }
            else if ((Define.ModuleMove_Mode == "LoadPortPlace") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            //
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // Aligner Pick Progress ////////////////////////////////////////////////////////////
        #region Aligner Pick Progress
        private void AlignerPickProgress()
        {
            if ((Define.ModuleMove_Mode == "AlignerPick") && (Define.ModuleMove_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "AlignerPickIng";

                Global.EventLog("ALIGNER PICK START", ModuleName, "Event");
            }
            else if ((Define.ModuleMove_Mode == "AlignerPick") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            //
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // Aligner Place Progress ///////////////////////////////////////////////////////////
        #region Aligner Place Progress
        private void AlignerPlaceProgress()
        {
            if ((Define.ModuleMove_Mode == "AlignerPlace") && (Define.ModuleMove_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "AlignerPlaceIng";

                Global.EventLog("ALIGNER PLACE START", ModuleName, "Event");
            }
            else if ((Define.ModuleMove_Mode == "AlignerPlace") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            //
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // PM Pick Progress /////////////////////////////////////////////////////////////////
        #region PM Pick Progress
        private void PMPickProgress()
        {
            if ((Define.ModuleMove_Mode == "PMPick") && (Define.ModuleMove_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "PMPickIng";

                Global.EventLog("PM PICK START", ModuleName, "Event");
            }
            else if ((Define.ModuleMove_Mode == "PMPick") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            //
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // PM Place Progress ////////////////////////////////////////////////////////////////
        #region PM Place Progress
        private void PMPlaceProgress()
        {
            if ((Define.ModuleMove_Mode == "PMPlace") && (Define.ModuleMove_Ctrl == "Run"))
            {
                Thread.Sleep(500);
                step.Layer = 1;
                step.Times = 1;
                step.Flag = true;

                Define.ModuleMove_Ctrl = "Running";
                Define.ModuleMove_Sts = "PMPlaceIng";

                Global.EventLog("PM PLACE START", ModuleName, "Event");
            }
            else if ((Define.ModuleMove_Mode == "PMPlace") && (Define.ModuleMove_Ctrl == "Running"))
            {
                switch (step.Layer)
                {
                    case 1:
                        {
                            //
                        }
                        break;
                }
            }
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
        ///
        // FUNCTION /////////////////////////////////////////////////////////////////////////
        #region Function
        private void MM_Pick(string stage)
        {
            //
        }
        #endregion
        /////////////////////////////////////////////////////////////////////////////////////
    }
}
