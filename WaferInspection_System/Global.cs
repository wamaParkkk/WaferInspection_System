using Ajin_IO_driver;
using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WaferInspection_System
{
    class Global
    {
        public static string userdataPath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\UserData.accdb"));
        public static string logfilePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\EventLog\"));
        public static string alarmHistoryPath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\AlarmHistory\"));        
        public static string ConfigurePath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\Configure\"));
        public static string serialPortInfoPath = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\"));


        private static Timer timer = new Timer();

        public static TDigSet digSet;
        public static TPrcsInfo prcsInfo;

        private static InterlockDisplayForm interlockDisplayForm;
        private static uint nSeqWaitCnt = 0;
                
        #region 이벤트로그 파일 폴더 및 파일 생성       
        public static void EventLog(string Msg, string moduleName, string Mode)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string sDate = sYear + "-" + sMonth + "-" + sDay;
            string sTime = DateTime.Now.ToString("HH:mm:ss");
            string sDateTime;
            sDateTime = "[" + sDate + ", " + sTime + "] ";

            WriteFile(sDateTime + Msg, moduleName, Mode);

            if (Mode == "Event")
            {
                if (moduleName == "LoadPort")
                {
                    Define.bLoadPortEvent = true;
                }

                if (moduleName == "Robot")
                {
                    Define.bRobotEvent = true;
                }

                if (moduleName == "Aligner")
                {
                    Define.bAlignerEvent = true;
                }

                if (moduleName == "PM")
                {
                    Define.bPMEvent = true;
                }
            }
            else if (Mode == "Alarm")
            {
                if (moduleName == "LoadPort")
                {
                    Define.bLoadPortOpAlmEvent = true;
                    Define.bLoadPortAlmEvent = true;
                }

                if (moduleName == "Robot")
                {
                    Define.bRobotOpAlmEvent = true;
                    Define.bRobotAlmEvent = true;
                }

                if (moduleName == "Aligner")
                {
                    Define.bAlignerOpAlmEvent = true;
                    Define.bAlignerAlmEvent = true;
                }

                if (moduleName == "PM")
                {
                    Define.bPMOpAlmEvent = true;
                    Define.bPMAlmEvent = true;
                }
            }            
        }

        private static void WriteFile(string Msg, string moduleName, string Mode)
        {            
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string FileName = sDay + ".txt";
            string sPath = string.Empty;
            if (Mode == "Event")
            {
                sPath = logfilePath;
            }                
            else if (Mode == "Alarm")
            {
                sPath = alarmHistoryPath;
            }

            try
            {
                if (!Directory.Exists(sPath + moduleName + "\\" + sYear))
                {
                    CreateYearFolder(sPath + moduleName);
                }

                if (!Directory.Exists(sPath + moduleName + "\\" + sYear + "\\" + sMonth))
                {
                    CreateMonthFolder(sPath + moduleName);
                }

                if (File.Exists(sPath + moduleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName))
                {
                    StreamWriter writer;
                    writer = File.AppendText(sPath + moduleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName);
                    writer.WriteLine(Msg);
                    writer.Close();
                }
                else
                {
                    CreateFile(sPath + moduleName, Msg);

                    StreamWriter writer;
                    writer = File.AppendText(sPath + moduleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName);
                    writer.WriteLine(Msg);
                    writer.Close();
                }
            }
            catch (IOException)
            {
                
            }
        }

        private static void CreateYearFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string FolderName = sYear;

            Directory.CreateDirectory(Path + "\\" + FolderName);
        }

        private static void CreateMonthFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string FolderName = sMonth;

            Directory.CreateDirectory(Path + "\\" + sYear + "\\" + FolderName);
        }

        private static void CreateFile(string Path, string Msg)
        {
            StreamWriter writer;

            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string FileName = sDay + ".txt";

            if (!File.Exists(Path + "\\" + sYear + "\\" + sMonth + "\\" + FileName))
            {
                using (File.Create(Path + "\\" + sYear + "\\" + sMonth + "\\" + FileName)) ;
            }
        }
        #endregion

        public static void Init()
        {
            // IO (Output) 채널 초기화
            digSet.curDigSet = new string[64];
            for (int i = 0; i < 64; i++)
            {
                digSet.curDigSet[i] = DIOClass.doVal.readDigOut[i];                
            }

            // Module 초기화
            Define.seqMode = new string[Define.MODULE_MAX];
            Define.seqCtrl = new string[Define.MODULE_MAX];
            Define.seqSts = new string[Define.MODULE_MAX];
            for (int i = 0; i < Define.MODULE_MAX; i++)
            {
                Define.seqMode[i] = "Idle";
                Define.seqCtrl[i] = "Idle";
                Define.seqSts[i] = "Idle";
            }

            // Load Port wafer 정보(개수) 초기화
            Define.LP_Wafer_In_Sts = new string[Define.WAFER_MAX];
            for (int i = 0; i < Define.WAFER_MAX; i++)
            {
                Define.LP_Wafer_In_Sts[i] = "None";
            }

            prcsInfo.prcsRecipeName = new string[Define.MODULE_MAX - 1];
            prcsInfo.prcsCurrentStep = new int[Define.MODULE_MAX - 1];
            prcsInfo.prcsTotalStep = new int[Define.MODULE_MAX - 1];
            prcsInfo.prcsStepName = new string[Define.MODULE_MAX - 1];
            prcsInfo.prcsStepCurrentTime = new double[Define.MODULE_MAX - 1];
            prcsInfo.prcsStepTotalTime = new double[Define.MODULE_MAX - 1];
            prcsInfo.prcsEndTime = new string[Define.MODULE_MAX - 1];

            for (int nModuleCnt = 0; nModuleCnt < Define.MODULE_MAX - 1; nModuleCnt++)
            {
                prcsInfo.prcsRecipeName[nModuleCnt] = string.Empty;
                prcsInfo.prcsCurrentStep[nModuleCnt] = 0;
                prcsInfo.prcsTotalStep[nModuleCnt] = 0;
                prcsInfo.prcsStepName[nModuleCnt] = string.Empty;
                prcsInfo.prcsStepCurrentTime[nModuleCnt] = 1;
                prcsInfo.prcsStepTotalTime[nModuleCnt] = 0;
                prcsInfo.prcsEndTime[nModuleCnt] = string.Empty;
            }

            interlockDisplayForm = new InterlockDisplayForm();            

            timer.Interval = 100;
            timer.Elapsed += new ElapsedEventHandler(VALUE_INTERLOCK_CHECK);
            timer.Start();
        }

        public static string GetDigValue(int ioName)
        {
            try
            {
                if ((0 <= ioName) && (15 >= ioName))
                {
                    if (DIOClass.diVal.checkHigh[ioName] != null)
                    {
                        return DIOClass.diVal.checkHigh[ioName];
                    }
                    else
                    {
                        return "Off";
                    }
                }
                else if ((16 <= ioName) && (32 >= ioName))
                {
                    if (DIOClass.diVal.checkLow[ioName - 16] != null)
                    {
                        return DIOClass.diVal.checkLow[ioName - 16];
                    }
                    else
                    {
                        return "Off";
                    }
                }
                else
                {
                    return "Off";
                }
            }
            catch (IOException)
            {
                return "Off";
            }
        }

        public static void SetDigValue(int ioName, uint setValue, string ModuleName)
        {
            try
            {
                string retMsg = string.Empty;

                if (SETPOINT_INTERLOCK_CHECK(ioName, setValue, ModuleName, ref retMsg))
                {
                    if ((0 <= ioName) && (31 >= ioName))
                    {
                        DIOClass.SelectHighIndex(ioName, setValue);
                    }
                    else if ((32 <= ioName) && (63 >= ioName))
                    {
                        DIOClass.SelectHighIndex2(ioName, setValue);
                    }

                    Define.sAlarmName = "";
                    IO_StrToInt.io_code = ioName.ToString();
                    string IO_Name = IO_StrToInt.io_code;
                    if (setValue == 1)
                    {
                        digSet.curDigSet[ioName] = "On";

                        if ((IO_Name == "Tower_Lamp_Red_o") ||
                            (IO_Name == "Tower_Lamp_Yellow_o") ||
                            (IO_Name == "Tower_Lamp_Green_o"))
                        {
                            //
                        }
                        else
                        {
                            EventLog(IO_Name + " : " + " On", ModuleName, "Event");
                        }
                    }
                    else
                    {
                        digSet.curDigSet[ioName] = "Off";

                        if ((IO_Name == "Tower_Lamp_Red_o") ||
                            (IO_Name == "Tower_Lamp_Yellow_o") ||
                            (IO_Name == "Tower_Lamp_Green_o"))
                        {
                            //
                        }
                        else
                        {
                            EventLog(IO_Name + " : " + " Off", ModuleName, "Event");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(retMsg, "Interlock");
                }
            }
            catch (IOException)
            {

            }
        }

        #region 항시 체크 인터락
        private static void VALUE_INTERLOCK_CHECK(object sender, ElapsedEventArgs e)
        {
            // Interlock이 해제 상태인지 체크
            if (!Define.bInterlockRelease)
            {
                /*
                if (GetDigValue((int)DigInputList.EMO_Switch_i) == "Off")
                {
                    if (Define.sInterlockMsg == string.Empty)
                    {
                        ALL_VALVE_CLOSE();
                        PROCESS_ABORT();

                        SetDigValue((int)DigOutputList.Buzzer_o, (uint)DigitalOffOn.On, "PM");

                        Define.sInterlockMsg = "Emergency occurrence!";
                        Define.sInterlockChecklist = "Check the emergency switch";

                        DialogResult result = interlockDisplayForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Define.sInterlockMsg = "";
                            Define.sInterlockChecklist = "";
                        }
                    }
                }
                
                if (GetDigValue((int)DigInputList.Front_Door_Sensor_i) == "Off")
                {
                    if (Define.sInterlockMsg == string.Empty)
                    {
                        Define.sInterlockMsg = "Front door is open!";
                        Define.sInterlockChecklist = "Check the front door sensor";

                        DialogResult result = interlockDisplayForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Define.sInterlockMsg = "";
                            Define.sInterlockChecklist = "";
                        }
                    }
                }

                if (GetDigValue((int)DigInputList.Left_Door_Sensor_i) == "Off")
                {
                    if (Define.sInterlockMsg == string.Empty)
                    {
                        Define.sInterlockMsg = "Left door is open!";
                        Define.sInterlockChecklist = "Check the left door sensor";

                        DialogResult result = interlockDisplayForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Define.sInterlockMsg = "";
                            Define.sInterlockChecklist = "";
                        }
                    }
                }

                if (GetDigValue((int)DigInputList.Right_Door_Sensor_i) == "Off")
                {
                    if (Define.sInterlockMsg == string.Empty)
                    {
                        Define.sInterlockMsg = "Right door is open!";
                        Define.sInterlockChecklist = "Check the right door sensor";

                        DialogResult result = interlockDisplayForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Define.sInterlockMsg = "";
                            Define.sInterlockChecklist = "";
                        }
                    }
                }

                if (GetDigValue((int)DigInputList.Back_Door_Sensor_i) == "Off")
                {
                    if (Define.sInterlockMsg == string.Empty)
                    {
                        Define.sInterlockMsg = "Back door is open!";
                        Define.sInterlockChecklist = "Check the back door sensor";

                        DialogResult result = interlockDisplayForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Define.sInterlockMsg = "";
                            Define.sInterlockChecklist = "";
                        }
                    }
                }
                */
            }            
        }
        #endregion

        #region 동작(IO) 명령 시 인터락
        private static bool SETPOINT_INTERLOCK_CHECK(int ioName, uint setValue, string ModuleName, ref string retMsg)
        {
            // Interlock이 해제 상태인지 체크
            if (Define.bInterlockRelease)
            {
                return true;
            }

            if (ModuleName == "LoadPort")
            {
                //
            }

            if (ModuleName == "Robot")
            {
                //
            }

            if (ModuleName == "Aligner")
            {
                //
            }

            if (ModuleName == "PM")
            {
                //
            }

            return true;
        }

        private static void ALL_VALVE_CLOSE()
        {            
            //
        }

        private static void PROCESS_ABORT()
        {
            //
        }
        #endregion

        public static bool Value_Check(string[] sValue)
        {
            bool bResult;
            int i;
            bool bRtn = true;
            double dVal = 0.0;

            for (i = 0; i < sValue.Length; i++)
            {
                bResult = double.TryParse(sValue[i], out dVal);
                if (!bResult)
                {
                    bRtn = false;
                    break;
                }
            }

            if (bRtn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
