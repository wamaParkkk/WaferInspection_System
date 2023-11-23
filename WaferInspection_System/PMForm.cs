using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WaferInspection_System
{
    public partial class PMForm : UserControl
    {
        private MaintnanceForm m_Parent;
        int module;
        string ModuleName;
        
        DigitalDlg digitalDlg;

        private Timer logdisplayTimer = new Timer();

        public PMForm(MaintnanceForm parent)
        {
            m_Parent = parent;

            module = (int)MODULE._PM;
            ModuleName = "PM";

            InitializeComponent();            
        }

        private void PMForm_Load(object sender, EventArgs e)
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
            //SetDoubleBuffered(Door_Open);

            // Process seq status
            

            // Input display


            // Output display
        }

        private void Eventlog_Display(object sender, ElapsedEventArgs e)
        {
            if (Define.bPMEvent)
            {
                Eventlog_File_Read();
            }

            if (Define.bPMAlmEvent)
            {
                Alarmlog_File_Read();
            }
        }

        private void Eventlog_File_Read()
        {
            Define.bPMEvent = false;
            
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
            Define.bPMAlmEvent = false;

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
                        digitalDlg.Init("Close", "Open", "PM Cover Door");
                        if (digitalDlg.ShowDialog() == DialogResult.OK)
                        {
                            if (digitalDlg.m_strResult == "Close")
                            {
                                //Global.SetDigValue((int)DigOutputList.CH2_Door_Open_o, (uint)DigitalOffOn.Off, ModuleName);
                                //Global.SetDigValue((int)DigOutputList.CH2_Door_Close_o, (uint)DigitalOffOn.On, ModuleName);
                            }
                            else
                            {
                                //Global.SetDigValue((int)DigOutputList.CH2_Door_Open_o, (uint)DigitalOffOn.On, ModuleName);
                                //Global.SetDigValue((int)DigOutputList.CH2_Door_Close_o, (uint)DigitalOffOn.Off, ModuleName);
                            }
                        }
                    }
                    break;                             
            }  
        }        
    }
}
