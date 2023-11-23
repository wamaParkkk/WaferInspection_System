using Ajin_IO_driver;
//using Ajin_motion_driver;
using Hirata_LoadPort_driver;
using Koro_Robot_driver;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WaferInspection_System
{
    public partial class MainForm : Form
    {
        LoginForm m_loginForm;
        OperationForm m_operationForm;
        MaintnanceForm m_maintnanceForm;        
        ConfigureForm m_configureForm;
        //IOForm m_ioForm;
        AlarmForm m_alarmForm;
        EventLogForm m_eventLogForm;
        UserRegistForm m_userRegistForm;

        Squence.TMMoving TMMoving;
        Squence.ModuleMoving ModuleMoving;

        public MainForm()
        {
            InitializeComponent();

            SubFormCreate();

            CreateThread();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Width = 1280;
            Height = 1024;
            Top = 0;
            Left = 0;

            Define.bLogin = false;
            Define.bOpActivate = false;

            MyNativeWindows myNativeWindows = new MyNativeWindows();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                MdiClient mdiClient = this.Controls[i] as MdiClient;
                if (mdiClient != null)
                {
                    myNativeWindows.ReleaseHandle();
                    myNativeWindows.AssignHandle(mdiClient.Handle);
                }
            }

            // IO보드 초기화            
            if (DIOClass.OpenDevice())
            {
                //m_ioForm.DI_Parsing_timer.Start();
            }
            
            Global.Init();

            // Load Port driver init
            LoadPortClass.LoadPort_Init();

            // Motion driver init
            //MotionClass.Ajin_Motion_Init();

            // Robot driver init
            RobotClass.Koro_robot_Init();

            timerDisplay.Enabled = true;
            simulationTimer.Enabled = true;

            SubFormShow((byte)Page.LogInPage);

            F_ButtonVisible(false, false, false, false, false, false, false);
        }

        public class MyNativeWindows : NativeWindow
        {
            public MyNativeWindows()
            {
            }

            private const int WM_NCCALCSIZE = 0x0083;
            private const int SB_BOTH = 3;

            [DllImport("user32.dll")]
            private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case WM_NCCALCSIZE:
                        ShowScrollBar(m.HWnd, SB_BOTH, 0);
                        break;
                }
                base.WndProc(ref m);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerDisplay.Enabled = false;
            simulationTimer.Enabled = false;

            FreeThread();

            Dispose();
        }

        private void SubFormCreate()
        {
            m_operationForm = new OperationForm();
            m_operationForm.MdiParent = this;
            m_operationForm.Show();

            m_loginForm = new LoginForm();
            m_loginForm.MdiParent = this;
            m_loginForm.Show();

            m_userRegistForm = new UserRegistForm();
            m_userRegistForm.MdiParent = this;
            m_userRegistForm.Show();

            m_maintnanceForm = new MaintnanceForm();
            m_maintnanceForm.MdiParent = this;
            m_maintnanceForm.Show();            

            m_configureForm = new ConfigureForm();
            m_configureForm.MdiParent = this;
            m_configureForm.Show();

            //m_ioForm = new IOForm();
            //m_ioForm.MdiParent = this;
            //m_ioForm.Show();

            m_alarmForm = new AlarmForm();
            m_alarmForm.MdiParent = this;
            m_alarmForm.Show();

            m_eventLogForm = new EventLogForm();
            m_eventLogForm.MdiParent = this;
            m_eventLogForm.Show();
        }

        private void CreateThread()
        {
            TMMoving = new Squence.TMMoving();
            ModuleMoving = new Squence.ModuleMoving();
        }

        private void FreeThread()
        {
            TMMoving.Dispose();
            ModuleMoving.Dispose();

            DIOClass.CloseDevice();
            //MotionClass.DRV_CLOSE();
            RobotClass._DRV_CLOSE();
        }

        public void SubFormShow(byte PageNum)
        {
            try
            {
                Define.currentPage = PageNum;
                byte iPage = PageNum;

                switch (iPage)
                {
                    case (byte)Page.LogInPage:
                        {
                            m_loginForm.Activate();
                            m_loginForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.OperationPage:
                        {
                            m_operationForm.Activate();
                            m_operationForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.MaintnancePage:
                        {
                            m_maintnanceForm.Activate();
                            m_maintnanceForm.BringToFront();

                            F_ModuleButtonVisible(true, true, true, true);

                            // 프로그램을 처음 켜고 Maintnance버튼을 눌렀을 때 초기화
                            if (Define.MaintCurrentPage == (byte)MODULE._LoadPort)
                                btnLoadPortModule.BackColor = Color.Lime;
                        }
                        break;
                        
                    case (byte)Page.ConfigurePage:
                        {
                            m_configureForm.Activate();
                            m_configureForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.IOPage:
                        {
                            //m_ioForm.Activate();
                            //m_ioForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.AlarmPage:
                        {
                            m_alarmForm.Activate();
                            m_alarmForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.EventLogPage:
                        {
                            m_eventLogForm.Activate();
                            m_eventLogForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;

                    case (byte)Page.UserRegist:
                        {
                            m_userRegistForm.Activate();
                            m_userRegistForm.BringToFront();

                            F_ModuleButtonVisible(false, false, false, false);
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("폼 양식을 가져오는 도중 오류가 발생했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_ButtonVisible(bool bOpBtn, bool bMaintBtn, bool bConfigureBtn, bool bIOBtn, bool bAlarmBtn, bool bEventLogBtn, bool bUserRegistBtn)
        {
            pictureBoxOperation.Enabled = bOpBtn;
            btnOperation.Enabled = bOpBtn;

            pictureBoxMain.Enabled = bMaintBtn;
            btnMaintnance.Enabled = bMaintBtn;
            
            pictureBoxConfigure.Enabled = bConfigureBtn;
            btnConfigure.Enabled = bConfigureBtn;

            pictureBoxIO.Enabled = bIOBtn;
            btnIO.Enabled = bIOBtn;

            pictureBoxAlarm.Enabled = bAlarmBtn;
            pictureBoxAlarm2.Enabled = bAlarmBtn;
            btnAlarm.Enabled = bAlarmBtn;

            pictureBoxEventLog.Enabled = bEventLogBtn;
            btnEventLog.Enabled = bEventLogBtn;

            pictureBoxUserRegist.Enabled = bUserRegistBtn;
            btnUserRegist.Enabled = bUserRegistBtn;
        }

        private void F_ModuleButtonVisible(bool bLoadPortBtn, bool bTMBtn, bool bAlignerBtn, bool bPMBtn)
        {
            btnLoadPortModule.Visible = bLoadPortBtn;
            btnTMModule.Visible = bTMBtn;
            btnAlignerModule.Visible = bAlignerBtn;
            btnPMModule.Visible = bPMBtn;
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (panelOption.Visible == false)
                panelOption.Visible = true;
            else
                panelOption.Visible = false;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.OperationPage);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.MaintnancePage);
        }        

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.ConfigurePage);
        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.IOPage);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.AlarmPage);
        }

        private void pictureBoxAlarm_Click(object sender, EventArgs e)
        {
            Global.SetDigValue((int)DigOutputList.Buzzer_o, (uint)DigitalOffOn.Off, "PM");
        }

        private void btnEventLog_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.EventLogPage);
        }

        private void btnUserRegist_Click(object sender, EventArgs e)
        {
            SubFormShow((byte)Page.UserRegist);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dispose();
                //Application.Exit();
                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string strTmp = btn.Text.ToString();
            switch (strTmp)
            {
                case "LP":
                    {
                        if (!m_maintnanceForm.m_loadPortForm.Visible)
                            m_maintnanceForm.m_loadPortForm.Visible = true;

                        if (m_maintnanceForm.m_TMForm.Visible != false)
                            m_maintnanceForm.m_TMForm.Visible = false;

                        if (m_maintnanceForm.m_AlignerForm.Visible != false)
                            m_maintnanceForm.m_AlignerForm.Visible = false;

                        if (m_maintnanceForm.m_PMForm.Visible != false)
                            m_maintnanceForm.m_PMForm.Visible = false;

                        btnLoadPortModule.BackColor = Color.Lime;
                        btnTMModule.BackColor = Color.Transparent;
                        btnAlignerModule.BackColor = Color.Transparent;
                        btnPMModule.BackColor = Color.Transparent;

                        Define.MaintCurrentPage = (byte)MODULE._LoadPort;
                    }
                    break;

                case "TM":
                    {
                        if (!m_maintnanceForm.m_TMForm.Visible)
                            m_maintnanceForm.m_TMForm.Visible = true;

                        if (m_maintnanceForm.m_loadPortForm.Visible != false)
                            m_maintnanceForm.m_loadPortForm.Visible = false;

                        if (m_maintnanceForm.m_AlignerForm.Visible != false)
                            m_maintnanceForm.m_AlignerForm.Visible = false;

                        if (m_maintnanceForm.m_PMForm.Visible != false)
                            m_maintnanceForm.m_PMForm.Visible = false;

                        btnLoadPortModule.BackColor = Color.Transparent;
                        btnTMModule.BackColor = Color.Lime;
                        btnAlignerModule.BackColor = Color.Transparent;
                        btnPMModule.BackColor = Color.Transparent;

                        Define.MaintCurrentPage = (byte)MODULE._TM;
                    }
                    break;

                case "Aligner":
                    {
                        if (!m_maintnanceForm.m_AlignerForm.Visible)
                            m_maintnanceForm.m_AlignerForm.Visible = true;

                        if (m_maintnanceForm.m_loadPortForm.Visible != false)
                            m_maintnanceForm.m_loadPortForm.Visible = false;

                        if (m_maintnanceForm.m_TMForm.Visible != false)
                            m_maintnanceForm.m_TMForm.Visible = false;

                        if (m_maintnanceForm.m_PMForm.Visible != false)
                            m_maintnanceForm.m_PMForm.Visible = false;

                        btnLoadPortModule.BackColor = Color.Transparent;
                        btnTMModule.BackColor = Color.Transparent;
                        btnAlignerModule.BackColor = Color.Lime;
                        btnPMModule.BackColor = Color.Transparent;

                        Define.MaintCurrentPage = (byte)MODULE._Aligner;
                    }
                    break;

                case "PM":
                    {
                        if (!m_maintnanceForm.m_PMForm.Visible)
                            m_maintnanceForm.m_PMForm.Visible = true;

                        if (m_maintnanceForm.m_loadPortForm.Visible != false)
                            m_maintnanceForm.m_loadPortForm.Visible = false;

                        if (m_maintnanceForm.m_TMForm.Visible != false)
                            m_maintnanceForm.m_TMForm.Visible = false;

                        if (m_maintnanceForm.m_AlignerForm.Visible != false)
                            m_maintnanceForm.m_AlignerForm.Visible = false;

                        btnLoadPortModule.BackColor = Color.Transparent;
                        btnTMModule.BackColor = Color.Transparent;
                        btnAlignerModule.BackColor = Color.Transparent;
                        btnPMModule.BackColor = Color.Lime;

                        Define.MaintCurrentPage = (byte)MODULE._PM;
                    }
                    break;
            }
        }

        private void checkBoxInterlockRelease_Click(object sender, EventArgs e)
        {
            if (checkBoxInterlockRelease.Checked)
            {
                checkBoxInterlockRelease.Checked = true;
                Define.bInterlockRelease = true;
            }
            else
            {
                checkBoxInterlockRelease.Checked = false;
                Define.bInterlockRelease = false;
            }
        }

        private void checkBoxSimulation_Click(object sender, EventArgs e)
        {
            if (checkBoxSimulation.Checked)
            {
                checkBoxSimulation.Checked = true;
                Define.bSimulation = true;

                Global.EventLog("Simulation mode is on.", "PM", "Event");
            }
            else
            {
                checkBoxSimulation.Checked = false;
                Define.bSimulation = false;

                Global.EventLog("Simulation mode is off.", "PM", "Event");
            }
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            laDate.Text = System.DateTime.Today.ToShortDateString();
            laTime.Text = System.DateTime.Now.ToLongTimeString();
            laUserLevel.Text = "Level : " + Define.UserLevel;

            if (Define.currentPage == (byte)Page.OperationPage)
            {
                labelPageName.Text = "Operation";
                if (Define.bOpActivate)
                {
                    m_operationForm.Activate();
                    m_operationForm.BringToFront();

                    Define.bOpActivate = false;
                }
            }
            else if (Define.currentPage == (byte)Page.MaintnancePage)
            {
                labelPageName.Text = "Maintnance";
            }            
            else if (Define.currentPage == (byte)Page.ConfigurePage)
            {
                labelPageName.Text = "Configure";
            }
            else if (Define.currentPage == (byte)Page.IOPage)
            {
                labelPageName.Text = "Input/Output";
            }
            else if (Define.currentPage == (byte)Page.AlarmPage)
            {
                labelPageName.Text = "Alarm";
            }
            else if (Define.currentPage == (byte)Page.EventLogPage)
            {
                labelPageName.Text = "Event Log";
            }
            else if (Define.currentPage == (byte)Page.UserRegist)
            {
                labelPageName.Text = "User regist";
                m_userRegistForm.BringToFront();
            }
            else if (Define.currentPage == (byte)Page.LogInPage)
            {
                labelPageName.Text = "Log-In";
            }

            // User level에 따른 버튼 활성화
            if (Define.UserLevel == "Master")
            {
                // op, maint, configure, io, alarm, eventlog, userRegist
                F_ButtonVisible(true, true, true, true, true, true, true);
            }
            else if (Define.UserLevel == "Maintnance")
            {
                F_ButtonVisible(true, true, true, true, true, true, false);
            }
            else if (Define.UserLevel == "User")
            {
                F_ButtonVisible(true, false, true, false, true, true, false);
            }


            // Tower lamp
            if ((Define.seqCtrl[(byte)MODULE._LoadPort] == "Alarm") ||
                (Define.seqCtrl[(byte)MODULE._TM] == "Alarm") ||
                (Define.seqCtrl[(byte)MODULE._Aligner] == "Alarm") ||
                (Define.seqCtrl[(byte)MODULE._PM] == "Alarm"))
            {
                if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != null)
                {
                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != "On")
                        Global.SetDigValue((int)DigOutputList.Tower_Lamp_Red_o, (uint)DigitalOffOn.On, "PM");
                    else
                        Global.SetDigValue((int)DigOutputList.Tower_Lamp_Red_o, (uint)DigitalOffOn.Off, "PM");
                }

                if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != null)
                {
                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != "Off")                        
                        Global.SetDigValue((int)DigOutputList.Tower_Lamp_Yellow_o, (uint)DigitalOffOn.Off, "PM");
                }

                if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != null)
                {
                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != "Off")
                        Global.SetDigValue((int)DigOutputList.Tower_Lamp_Green_o, (uint)DigitalOffOn.Off, "PM");
                }

                if (pictureBoxAlarm.Visible)
                    pictureBoxAlarm.Visible = false;
                else
                    pictureBoxAlarm.Visible = true;
            }
            else
            {
                if ((Define.seqCtrl[(byte)MODULE._LoadPort] == "Idle") &&
                    (Define.seqCtrl[(byte)MODULE._TM] == "Idle") &&
                    (Define.seqCtrl[(byte)MODULE._Aligner] == "Idle") &&
                    (Define.seqCtrl[(byte)MODULE._PM] == "Idle"))                    
                {
                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != "Off")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Red_o, (uint)DigitalOffOn.Off, "PM");
                    }

                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != "On")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Yellow_o, (uint)DigitalOffOn.On, "PM");
                    }

                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != "Off")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Green_o, (uint)DigitalOffOn.Off, "PM");
                    }

                    if (pictureBoxAlarm.Visible != false)
                        pictureBoxAlarm.Visible = false;
                }
                else
                {
                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Red_o] != "Off")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Red_o, (uint)DigitalOffOn.Off, "PM");
                    }

                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Yellow_o] != "Off")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Yellow_o, (uint)DigitalOffOn.Off, "PM");
                    }

                    if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != null)
                    {
                        if (Global.digSet.curDigSet[(int)DigOutputList.Tower_Lamp_Green_o] != "On")
                            Global.SetDigValue((int)DigOutputList.Tower_Lamp_Green_o, (uint)DigitalOffOn.On, "PM");                        
                    }
                }

                if (pictureBoxAlarm.Visible != false)
                    pictureBoxAlarm.Visible = false;
            }


            if (Define.bInterlockRelease)
            {
                if (labelInterlockEnaDis.Visible)
                    labelInterlockEnaDis.Visible = false;
                else
                    labelInterlockEnaDis.Visible = true;
            }
            else
            {
                if (labelInterlockEnaDis.Visible != false)
                    labelInterlockEnaDis.Visible = false;
            }
        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            if (Define.bSimulation)
            {
                DIOClass.diVal.checkHigh[(int)DigInputList.EMO_Switch_i] = "On";

                // Load Port


                // Robot


                // Aligner


                // PM
            }
        }
    }
}
