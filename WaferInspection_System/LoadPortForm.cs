using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using Hirata_LoadPort_driver;
using System.Drawing;

namespace WaferInspection_System
{
    public partial class LoadPortForm : UserControl
    {
        private MaintnanceForm m_Parent;
        int module;
        string ModuleName;
        
        DigitalDlg digitalDlg;

        private Timer logdisplayTimer = new Timer();

        public LoadPortForm(MaintnanceForm parent)
        {
            m_Parent = parent;

            module = (int)MODULE._LoadPort;
            ModuleName = "LoadPort";

            InitializeComponent();            
        }

        private void LoadPortForm_Load(object sender, EventArgs e)
        {
            Width = 1172;
            Height = 824;
            Top = 0;
            Left = 0;

            logdisplayTimer.Interval = 100;
            logdisplayTimer.Elapsed += new ElapsedEventHandler(Eventlog_Display);
            logdisplayTimer.Start();
        }

        private void SetDoubleBuffered(Control control, bool doubleBuffered = true)
        {
            PropertyInfo propertyInfo = typeof(Control).GetProperty
            (
                "DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic
            );
            propertyInfo.SetValue(control, doubleBuffered, null);
        }

        public void Display()
        {
            //SetDoubleBuffered(Door_Close);

            // IO display

            // Load port status display
            LoadPortDeviceSts.Text = LoadPortClass.loadPortStatus.sR_DeviceSts;
            LoadPortOperationSts.Text = LoadPortClass.loadPortStatus.sR_OperationSts;
            LoadPortContainerSts.Text = LoadPortClass.loadPortStatus.sR_ContainerSts;
            LoadPortClampPosition.Text = LoadPortClass.loadPortStatus.sR_ClampPosition;
            LoadPortDoorLatchPosition.Text = LoadPortClass.loadPortStatus.sR_DoorLatchPosition;
            LoadPortAdsorptionSts.Text = LoadPortClass.loadPortStatus.sR_AdsorptionSts;
            LoadPortDoorPosition.Text = LoadPortClass.loadPortStatus.sR_DoorPosition;
            LoadPortWaferProtrusion.Text = LoadPortClass.loadPortStatus.sR_WaferProtrusionSns;
            LoadPortElevatorPosition.Text = LoadPortClass.loadPortStatus.sR_ElevatorAxisPosition;
            LoadPortDockPosition.Text = LoadPortClass.loadPortStatus.sR_DockPosition;
            LoadPortMappWaitPosition.Text = LoadPortClass.loadPortStatus.sR_MappWaitPosition;
            LoadPortMappSts.Text = LoadPortClass.loadPortStatus.sR_MappSts;
            LoadPortType.Text = LoadPortClass.loadPortStatus.sR_Type;
            LoadPortErrorSts.Text = LoadPortClass.loadPortStatus.sR_ErrorSts;

            if (LoadPortClass.loadPortStatus.sR_ErrorCode[0] != null)
                LoadPortErrorCode10.Text = LoadPortClass.loadPortStatus.sR_ErrorCode[0];

            if (LoadPortClass.loadPortStatus.sR_ErrorCode[1] != null)
                LoadPortErrorCode01.Text = LoadPortClass.loadPortStatus.sR_ErrorCode[1];

            // Load port LED
            if (LoadPortClass.ledStatus.sR_Presence == "On")
            {
                LoadPortLED_Presence.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Presence.BackColor != Color.Lime)
                    LoadPortLED_Presence.BackColor = Color.Lime;
                else
                    LoadPortLED_Presence.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Presence.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_Placement == "On")
            {
                LoadPortLED_Placement.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Placement.BackColor != Color.Lime)
                    LoadPortLED_Placement.BackColor = Color.Lime;
                else
                    LoadPortLED_Placement.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Placement.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_Load == "On")
            {
                LoadPortLED_Load.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Load.BackColor != Color.Lime)
                    LoadPortLED_Load.BackColor = Color.Lime;
                else
                    LoadPortLED_Load.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Load.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_Unload == "On")
            {
                LoadPortLED_Unload.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Unload.BackColor != Color.Lime)
                    LoadPortLED_Unload.BackColor = Color.Lime;
                else
                    LoadPortLED_Unload.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Unload.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_OpAccess1 == "On")
            {
                LoadPortLED_OperatorAccess1.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_OperatorAccess1.BackColor != Color.Lime)
                    LoadPortLED_OperatorAccess1.BackColor = Color.Lime;
                else
                    LoadPortLED_OperatorAccess1.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_OperatorAccess1.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_Status1 == "On")
            {
                LoadPortLED_Status1.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Status1.BackColor != Color.Lime)
                    LoadPortLED_Status1.BackColor = Color.Lime;
                else
                    LoadPortLED_Status1.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Status1.BackColor = Color.Silver;
            }

            if (LoadPortClass.ledStatus.sR_Status2 == "On")
            {
                LoadPortLED_Status2.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_Status2.BackColor != Color.Lime)
                    LoadPortLED_Status2.BackColor = Color.Lime;
                else
                    LoadPortLED_Status2.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_Status2.BackColor = Color.Silver;
            }
            /*
            if (LoadPortClass.ledStatus.sR_OpAccess2 == "On")
            {
                LoadPortLED_OperatorAccess2.BackColor = Color.Lime;
            }
            else if (LoadPortClass.ledStatus.sR_Presence == "Blink")
            {
                if (LoadPortLED_OperatorAccess2.BackColor != Color.Lime)
                    LoadPortLED_OperatorAccess2.BackColor = Color.Lime;
                else
                    LoadPortLED_OperatorAccess2.BackColor = Color.Silver;
            }
            else
            {
                LoadPortLED_OperatorAccess2.BackColor = Color.Silver;
            }
            */
        }

        private void Eventlog_Display(object sender, ElapsedEventArgs e)
        {
            if (Define.bLoadPortEvent)
            {
                Eventlog_File_Read();
            }

            if (Define.bLoadPortAlmEvent)
            {
                Alarmlog_File_Read();
            }
        }

        private void Eventlog_File_Read()
        {
            Define.bLoadPortEvent = false;
            
            try
            {
                string sTmpData;

                string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
                string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
                string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
                string FileName = sDay + ".txt";

                if (File.Exists(Global.logfilePath + ModuleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName))
                {
                    byte[] bytes;
                    using (var fs = File.Open(Global.logfilePath + ModuleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        bytes = new byte[fs.Length];
                        fs.Read(bytes, 0, (int)fs.Length);
                        sTmpData = Encoding.Default.GetString(bytes);

                        string[] data = sTmpData.Split('\n');
                        int iLength = data.Length;
                        if (iLength >= 2)
                        {
                            string sVal = data[iLength - 2].ToString();

                            Invoke((Action)(() =>
                            {
                                listBoxEventLog.Update();

                                if (listBoxEventLog.Items.Count >= 10)
                                    listBoxEventLog.Items.Clear();

                                listBoxEventLog.Items.Add(sVal);
                                listBoxEventLog.SelectedIndex = listBoxEventLog.Items.Count - 1;
                            }));
                        }
                    }
                }
            }
            catch (IOException)
            {

            }
        }

        private void Alarmlog_File_Read()
        {
            Define.bLoadPortAlmEvent = false;

            try
            {
                string sTmpData;

                string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
                string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
                string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
                string FileName = sDay + ".txt";

                if (File.Exists(Global.alarmHistoryPath + ModuleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName))
                {
                    byte[] bytes;
                    using (var fs = File.Open(Global.alarmHistoryPath + ModuleName + "\\" + sYear + "\\" + sMonth + "\\" + FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        bytes = new byte[fs.Length];
                        fs.Read(bytes, 0, (int)fs.Length);
                        sTmpData = Encoding.Default.GetString(bytes);

                        string[] data = sTmpData.Split('\n');
                        int iLength = data.Length;
                        if (iLength >= 2)
                        {
                            string sVal = data[iLength - 2].ToString();

                            Invoke((Action)(() =>
                            {                                
                                label_Alarm.Text = sVal;
                            }));
                        }
                    }
                }
            }
            catch (IOException)
            {

            }
        }        

        private void LoadPort_Control_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string strBtn = btn.Text;

            switch (strBtn)
            {
                case "E-Clear":
                    {
                        // 에러 해제
                        LoadPortClass.ErrorClear();
                    }
                    break;

                case "Retry":
                    {
                        // 동작 Retry
                        // 동작 정지(계속 동작 불가)시 실행 가능        
                        LoadPortClass.Retry();
                    }
                    break;

                case "Stop":
                    {
                        // 동작 정지(계속 동작 불가)        
                        LoadPortClass.Stop();
                    }
                    break;

                case "Resume":
                    {
                        // 동작 계속
                        // 동작 정지(계속 동작 가능) 시 실행 가능
                        LoadPortClass.Resume();
                    }
                    break;

                case "Pause":
                    {
                        // 동작 정지(계속 동작 가능)
                        LoadPortClass.Pause();
                    }
                    break;

                case "Abort":
                    {
                        // 커맨드 어보트
                        // 동작 정지 시 실행 가능(계속 동작, 동작 리트라이 불가)
                        LoadPortClass.Abort();
                    }
                    break;

                case "Origin":
                    {
                        // 초기 위치로 이동
                        LoadPortClass.Origin();
                    }
                    break;

                case "F.Origin":
                    {
                        // 초기 위치로 강제 이동
                        LoadPortClass.ForcedOrigin();
                    }
                    break;

                case "Load":
                    {
                        // 언로드 상태에서 로드 상태로 이동
                        LoadPortClass.UnloadToLoad();
                    }
                    break;

                case "Unload":
                    {
                        // 로드 상태에서 언로드 상태로 이동
                        LoadPortClass.LoadToUnload();
                    }
                    break;
            }  
        }
    }
}
