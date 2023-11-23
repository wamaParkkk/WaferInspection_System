using System.Threading;

namespace WaferInspection_System
{
    public struct TStep
    {
        public bool Flag;
        public byte Layer;
        public double Times;

        public void INC_TIMES()
        {
            Times++;
            Thread.Sleep(990);
        }

        public void INC_TIMES_10()
        {
            Times += 0.01;
        }

        public void INC_TIMES_100()
        {
            Times += 0.1;
        }
    }

    public class TBaseThread
    {
        public byte module;
        public string ModuleName;

        public TStep step;
    }

    public enum MODULE
    {
        _LoadPort = 0,
        _TM = 1,
        _Aligner = 2,
        _PM = 3
    }

    public enum Page
    {
        LogInPage = 0,
        OperationPage = 1,
        MaintnancePage = 2,        
        ConfigurePage = 3,
        IOPage = 4,
        AlarmPage = 5,
        EventLogPage = 6,
        UserRegist = 7
    }

    public enum DigitalOffOn
    {
        Off = 0,
        On = 1
    }

    public enum DigitalOnOff
    {
        On = 0,
        Off = 1
    }

    public struct TDigSet
    {
        public string[] curDigSet;
    }

    // 공정 진행 시 화면에 표시해줄 내용
    public struct TPrcsInfo
    {
        public string[] prcsRecipeName;
        public int[] prcsCurrentStep;
        public int[] prcsTotalStep;
        public string[] prcsStepName;
        public double[] prcsStepCurrentTime;
        public double[] prcsStepTotalTime;
        public string[] prcsEndTime;
    }

    // IO LIST /////////////////////////////////////////////
    public enum DigInputList
    {        
        EMO_Switch_i = 0,        
    }

    public enum DigOutputList
    {        
        Tower_Lamp_Red_o = 0,
        Tower_Lamp_Yellow_o = 1,
        Tower_Lamp_Green_o = 2,
        Buzzer_o = 3
    }
    ////////////////////////////////////////////////////////

    // IO (String to int)///////////////////////////////////
    public static class IO_StrToInt
    {
        private static string _io_Name = "";

        public static string io_code
        {
            get
            {
                if (string.IsNullOrEmpty(_io_Name))
                {
                    _io_Name = "IO Name is null";
                }

                return _io_Name;
            }
            set
            {
                if (value == "0")     _io_Name = "Tower_Lamp_Red_o";
                else if (value == "1")     _io_Name = "Tower_Lamp_Yellow_o";
                else if (value == "2")     _io_Name = "Tower_Lamp_Green_o";
                else if (value == "3")     _io_Name = "Buzzer_o";
            }
        }
    }
    ////////////////////////////////////////////////////////

    // ALARM LIST //////////////////////////////////////////
    public class Alarm_List
    {
        private string _alarm_Name = "";

        public string alarm_code
        {
            get
            {
                if (string.IsNullOrEmpty(_alarm_Name))
                {
                    _alarm_Name = "Alarm name is missing";
                }

                return _alarm_Name;
            }
            set
            {
                if (value == "900") _alarm_Name = "Tool does not exist";
                else if (value == "1000") _alarm_Name = "Door open time out";
                else if (value == "1001") _alarm_Name = "Door close time out";
                else if (value == "1002") _alarm_Name = "Failed to read recipe file";
                else if (value == "1005") _alarm_Name = "Cylinder forward time out";
                else if (value == "1006") _alarm_Name = "Cylinder backward time out";
                else if (value == "1007") _alarm_Name = "Cylinder home time out";
                else if (value == "1008") _alarm_Name = "Water filling has timed out";
                else if (value == "1009") _alarm_Name = "Water heating has timed out";

            }
        }
    }
    ////////////////////////////////////////////////////////

    // CONFIGURE LIST //////////////////////////////////////
    public class Configure_List
    {
        // System
        public static int Door_OpCl_Timeout = 0;
        public static int Brush_FwdBwd_Timeout = 0;
        public static int Nozzle_FwdBwd_Timeout = 0;
        public static int Table_UpDn_Timeout = 0;

        // Motion parameter (공정 진행 시)
        public static double Brush_Rotation_Speed = 0;
        public static double Brush_UpDown_Speed = 0;
        public static double Brush_Up_Position = 0;
        public static double Brush_Down_Position = 0;
        public static double WaterBlock_Move_Speed = 0;
        public static double Cmd_Move_Timeout = 0;        
    }
    ////////////////////////////////////////////////////////
    
    class Define
    {
        public const int BUFSIZ = 512;
        public const int MODULE_MAX = 4;
        public const int CH_MAX = 32;
        public const int RECIPE_MAX_STEP = 50;
        public const int WAFER_MAX = 25;

        // Login 여부
        public static bool bLogin = false;

        // User info
        public static string UserId = "";
        public static string UserName = "";
        public static string UserLevel = "";

        // Eventlog 발생 여부
        public static bool bLoadPortEvent;
        public static bool bRobotEvent;
        public static bool bAlignerEvent;
        public static bool bPMEvent;

        public static bool bLoadPortAlmEvent;
        public static bool bRobotAlmEvent;
        public static bool bAlignerAlmEvent;
        public static bool bPMAlmEvent;
        public static bool bLoadPortOpAlmEvent;
        public static bool bRobotOpAlmEvent;
        public static bool bAlignerOpAlmEvent;
        public static bool bPMOpAlmEvent;


        public static bool bOpActivate = false;
        public static byte currentPage = 0;
        public static byte MaintCurrentPage = 0;

        public static bool bInterlockRelease = false;
        public static string sInterlockMsg = "";        
        public static string sInterlockChecklist = "";
        public static bool bDoorAutoRelease = false;
        public static bool bSimulation = false;

        // Process sequence에서 사용 할 변수        
        public static string[] seqMode;         // "Idle", "Process"
        public static string[] seqCtrl;         // "Idle", "Run", "Running", "Alarm", "Retry", "Hold", "Resume", "Abort"
        public static string[] seqSts;          // "Idle", "ProcessIng", "ProcessOK", "AbortOK"

        // Manual Moving sequence에서 사용 할 변수
        public static string Move_Mode;         // "Idle", "Move"
        public static string Move_Ctrl;
        public static string Move_Sts;          // "Idle", "MoveIng", "MoveOK", "AbortOK"       

        public static string Move_Source;
        public static string Move_Target;
        public static string Move_Source_Slot;
        public static string Move_Target_Slot;

        // Moving sequence에서 사용 할 변수
        public static string ModuleMove_Mode;   // "Idle", "LoadPortPick", "LoadPortPlace", "AlignerPick", "AlignerPlace", "PMPick", "PMPlace"
        public static string ModuleMove_Ctrl;
        public static string ModuleMove_Sts;    // "Idle", "LoadPortPickIng", "LoadPortPickOK" ..... "AbortOK"

        // Mapping sequence에서 사용 할 변수
        public static string Map_Mode;          // "Idle", "Map"
        public static string Map_Ctrl;
        public static string Map_Sts;           // "Idle", "MapIng", "MapOK", "AbortOK"


        public static string DryRun_Mode;
        public static string DryRun_Ctrl;
        public static string DryRun_Sts; 


        // 알람 name
        public static string sAlarmName;

        // Chamber Enable/Disable
        public static bool[] bChamberDisable = { false, false, false, false };

        // Wafer info
        public static string TM_Wafer_In_Sts = "None";
        public static string[] LP_Wafer_In_Sts;
        public static string Aligner_Wafer_In_Sts = "None";
        public static string PM_Wafer_In_Sts = "None";        

        // Motor axis
        public const uint axis_x = 0;
        public const uint axis_y = 1;
    }    
}
