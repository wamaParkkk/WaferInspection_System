using Koro_Robot_driver;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WaferInspection_System
{
    public partial class TMForm : UserControl
    {
        private MaintnanceForm m_Parent;
        int module;
        string ModuleName;       

        DigitalDlg digitalDlg;

        private Timer logdisplayTimer = new Timer();

        public TMForm(MaintnanceForm parent)
        {
            m_Parent = parent;

            module = (int)MODULE._TM;
            ModuleName = "TM";

            InitializeComponent();
        }

        private void TMForm_Load(object sender, EventArgs e)
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
            SetDoubleBuffered(Robot);

            // IO display
            
            // Moving (Robot) display
            RobotInitStatus.Text = RobotClass.robotStatus[0].sR_Initial;
            RobotBusyStatus.Text = RobotClass.robotStatus[0].sR_Busy;
            RobotArmStatus.Text = RobotClass.robotStatus[0].sR_Arm_A;
            RobotZaxisStatus.Text = RobotClass.robotStatus[0].sR_Axis_Z;
            RobotPauseStatus.Text = RobotClass.robotStatus[0].sR_Pause;
            /*
            if ((RobotClass.robotStatus[0].sR_StageNum[0] != null) && (RobotClass.robotStatus[0].sR_StageNum[1] != null))
            {
                RobotStage10.Text = RobotClass.robotStatus[0].sR_StageNum[0];
                RobotStage1.Text = RobotClass.robotStatus[0].sR_StageNum[1];
            }

            if ((RobotClass.robotStatus[0].sR_ErrorSts[0] != null) && (RobotClass.robotStatus[0].sR_ErrorSts[1] != null))
            {
                RobotErrorStatus10.Text = RobotClass.robotStatus[0].sR_ErrorSts[0];
                RobotErrorStatus1.Text = RobotClass.robotStatus[0].sR_ErrorSts[1];
            }*/
        }

        private void Eventlog_Display(object sender, ElapsedEventArgs e)
        {
            if (Define.bRobotEvent)
            {                
                Eventlog_File_Read();                
            }

            if (Define.bRobotAlmEvent)
            {
                Alarmlog_File_Read();
            }
        }

        private void Eventlog_File_Read()
        {
            Define.bRobotEvent = false;
            
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
            Define.bRobotAlmEvent = false;

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

        private void Digital_Click(object sender, EventArgs e)
        {
            TextBox btn = (TextBox)sender;
            digitalDlg = new DigitalDlg();

            string strTmp = btn.Tag.ToString();
            switch (strTmp)
            {
                case "0":
                    {
                        digitalDlg.Init("Close", "Open", "Robot Cover Door");
                        if (digitalDlg.ShowDialog() == DialogResult.OK)
                        {
                            if (digitalDlg.m_strResult == "Close")
                            {
                                //Global.SetDigValue((int)DigOutputList.CH1_Door_Open_o, (uint)DigitalOffOn.Off, ModuleName);
                                //Global.SetDigValue((int)DigOutputList.CH1_Door_Close_o, (uint)DigitalOffOn.On, ModuleName);
                            }
                            else
                            {
                                //Global.SetDigValue((int)DigOutputList.CH1_Door_Open_o, (uint)DigitalOffOn.On, ModuleName);
                                //Global.SetDigValue((int)DigOutputList.CH1_Door_Close_o, (uint)DigitalOffOn.Off, ModuleName);
                            }
                        }
                    }
                    break;
            }
        }

        private void SourceStage_DropDown(object sender, EventArgs e)
        {
            int LPCnt = 0;
            SourceStage.Items.Clear();
            SourceSlotNo.Items.Clear();

            if (Define.TM_Wafer_In_Sts == "In")
            {
                SourceStage.Items.Add("TM");
            }
            else
            {
                if (Define.TM_Wafer_In_Sts == "None")
                {
                    if ((Define.Map_Mode == "Idle") && (Define.Map_Ctrl == "Idle"))
                    {
                        for (int i = 0; i < Define.WAFER_MAX; i++)
                        {
                            if (Define.LP_Wafer_In_Sts[i] == "In")
                            {
                                LPCnt++;
                            }
                        }

                        if (LPCnt > 0)
                            SourceStage.Items.Add("LoadPort");
                    }

                    if ((Define.seqMode[(byte)MODULE._Aligner] == "Idle") && (Define.seqCtrl[(byte)MODULE._Aligner] == "Idle"))
                    {
                        if (Define.Aligner_Wafer_In_Sts == "In")
                        {
                            SourceStage.Items.Add("Aligner");
                        }
                    }

                    if ((Define.seqMode[(byte)MODULE._PM] == "Idle") && (Define.seqCtrl[(byte)MODULE._PM] == "Idle"))
                    {
                        if (Define.PM_Wafer_In_Sts == "In")
                        {
                            SourceStage.Items.Add("PM");
                        }
                    }
                }
            }
        }

        private void TargetStage_DropDown(object sender, EventArgs e)
        {
            int LPCnt = 0;
            TargetStage.Items.Clear();
            TargetSlotNo.Items.Clear();

            if (Define.TM_Wafer_In_Sts == "None")
            {
                TargetStage.Items.Add("TM");
            }

            if ((Define.Map_Mode == "Idle") && (Define.Map_Ctrl == "Idle"))
            {
                for (int i = 0; i < Define.WAFER_MAX; i++)
                {
                    if (Define.LP_Wafer_In_Sts[i] == "None")
                    {
                        LPCnt++;
                    }
                }

                if (LPCnt > 0)
                    TargetStage.Items.Add("LoadPort");
            }

            if ((Define.seqMode[(byte)MODULE._Aligner] == "Idle") && (Define.seqCtrl[(byte)MODULE._Aligner] == "Idle"))
            {
                if (Define.Aligner_Wafer_In_Sts == "None")
                {
                    TargetStage.Items.Add("Aligner");
                }
            }

            if ((Define.seqMode[(byte)MODULE._PM] == "Idle") && (Define.seqCtrl[(byte)MODULE._PM] == "Idle"))
            {
                if (Define.PM_Wafer_In_Sts == "None")
                {
                    TargetStage.Items.Add("PM");
                }
            }
        }

        private void SourceSlotNo_DropDown(object sender, EventArgs e)
        {
            SourceSlotNo.Items.Clear();

            if (SourceStage.Items[SourceStage.SelectedIndex].ToString() == "LoadPort")
            {
                for (int i = 0; i < Define.WAFER_MAX; i++)
                {
                    if (Define.LP_Wafer_In_Sts[i] == "In")
                    {
                        SourceSlotNo.Items.Add(string.Format("{0:D2}", i + 1));
                    }
                }
            }
        }

        private void TargetSlotNo_DropDown(object sender, EventArgs e)
        {
            TargetSlotNo.Items.Clear();

            if (TargetStage.Items[TargetStage.SelectedIndex].ToString() == "LoadPort")
            {
                for (int i = 0; i < Define.WAFER_MAX; i++)
                {
                    if (Define.LP_Wafer_In_Sts[i] == "None")
                    {
                        TargetSlotNo.Items.Add(string.Format("{0:D2}", i + 1));
                    }
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string source_module, source_slot;
            string target_module, target_slot;            

            source_module = SourceStage.Text;
            target_module = TargetStage.Text;
            source_slot = SourceSlotNo.Text;
            target_slot = TargetSlotNo.Text;

            if (source_module == "")
            {
                MessageBox.Show("Source module is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (target_module == "")
            {
                MessageBox.Show("Target module is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (source_module == "LoadPort")
            {
                if (source_slot == "")
                {
                    MessageBox.Show("Source slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (target_module == "LoadPort")
            {
                if (target_slot == "")
                {
                    MessageBox.Show("Target slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            Define.Move_Source = source_module;
            Define.Move_Target = target_module;

            if (source_module == "LoadPort")
                Define.Move_Source_Slot = source_slot;

            if (target_module == "LoadPort")
                Define.Move_Target_Slot = target_slot;


            Define.Move_Mode = "Move";
            Define.Move_Ctrl = "Run";
            Define.Move_Sts = "Idle";
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            RobotClass.SetRobotHome();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            RobotClass.Stop();
        }

        private void Robot_Control_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;            
            string strBtn = btn.Text;
            string strTag = btn.Tag.ToString();

            string selectedStage;
            int stage = 0;
            int slot = 0;            

            switch (strBtn)
            {
                case "Rotation":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();
                        slot = Convert.ToInt32(ModuleSlotNo.Items[ModuleSlotNo.SelectedIndex]);

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;                        
                        else if (selectedStage == "PM")
                            stage = 4;                        

                        if ((stage >= 0) && (slot >= 0))
                        {
                            RobotClass.DownRotation(stage, slot);
                        }                            
                        else
                        {
                            MessageBox.Show("Stage or slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                            
                    }
                    break;

                case "Retract":
                    {
                        RobotClass.Retract();
                    }
                    break;

                case "Extend":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();                        

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;

                        if (stage >= 0)
                        {
                            RobotClass.Extend(stage);
                        }
                        else
                        {
                            MessageBox.Show("Stage is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case "Z-Up":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();                        

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;

                        if (stage >= 0)
                        {
                            RobotClass.Up(stage);
                        }
                        else
                        {
                            MessageBox.Show("Stage is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case "Z-Down":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();                        

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;

                        if (stage >= 0)
                        {
                            RobotClass.Down(stage);
                        }
                        else
                        {
                            MessageBox.Show("Stage is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case "Vacuum":
                    {
                        if (strTag == "0")
                        {
                            RobotClass.Vacuum("On");
                            btn.Tag = "1";
                        }
                        else
                        {
                            RobotClass.Vacuum("Off");
                            btn.Tag = "0";
                        }
                    }
                    break;

                case "Pick":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();
                        slot = Convert.ToInt32(ModuleSlotNo.Items[ModuleSlotNo.SelectedIndex]);

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;                        

                        if ((stage >= 0) && (slot >= 0))
                        {
                            RobotClass.Pick(stage, slot);
                        }
                        else
                        {
                            MessageBox.Show("Stage or slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case "Place":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();
                        slot = Convert.ToInt32(ModuleSlotNo.Items[ModuleSlotNo.SelectedIndex]);

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;                        

                        if ((stage >= 0) && (slot >= 0))
                        {
                            RobotClass.Place(stage + 2, slot);
                        }
                        else
                        {
                            MessageBox.Show("Stage or slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;

                case "EMG":
                    {
                        RobotClass.EMG_Stop();
                    }
                    break;

                case "Stop":
                    {
                        RobotClass.Stop();
                    }
                    break;                

                case "Pause":
                    {
                        RobotClass.Pause();
                    }
                    break;

                case "Resume":
                    {
                        RobotClass.Resume();
                    }
                    break;

                case "Home":
                    {
                        RobotClass.SetRobotHome();
                    }
                    break;

                case "Reset":
                    {
                        RobotClass.Error_Data_Reset();
                    }
                    break;

                case "Mapping sensor power":
                    {
                        if (strTag == "0")
                        {
                            RobotClass.MappingSensorPower("On");
                            btn.Tag = "1";
                        }
                        else
                        {
                            RobotClass.MappingSensorPower("Off");
                            btn.Tag = "0";
                        }
                    }
                    break;

                case "Mapping":
                    {
                        selectedStage = ModuleStage.SelectedItem.ToString();
                        slot = Convert.ToInt32(ModuleSlotNo.Items[ModuleSlotNo.SelectedIndex]);

                        if (selectedStage == "LoadPort")
                            stage = 1;
                        else if (selectedStage == "Aligner")
                            stage = 2;
                        else if (selectedStage == "PM")
                            stage = 4;                        

                        if ((stage >= 0) && (slot >= 0))
                        {
                            RobotClass.Mapping(stage, slot);
                        }
                        else
                        {
                            MessageBox.Show("Stage or slot is not selected", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Define.DryRun_Mode = "Test";
            Define.DryRun_Ctrl = "Run";
            Define.DryRun_Sts = "Idle";
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Define.DryRun_Ctrl = "Abort";            
        }
    }
}
