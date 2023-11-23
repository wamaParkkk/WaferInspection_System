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
    public partial class OperationForm : Form
    {        
        private Timer logdisplayTimer = new Timer();

        public OperationForm()
        {
            InitializeComponent();
        }

        private void OperationForm_Load(object sender, EventArgs e)
        {
            Width = 1172;
            Height = 824;
            Top = 0;
            Left = 0;

            displayTimer.Enabled = true;

            logdisplayTimer.Interval = 100;
            logdisplayTimer.Elapsed += new ElapsedEventHandler(Eventlog_Display);
            logdisplayTimer.Start();
        }

        private void OperationForm_Activated(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            //SetDoubleBuffered(PM1_Door_Close);                        
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

        private void OperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            displayTimer.Enabled = false;
            logdisplayTimer.Stop();

            Dispose();
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            //
        }

        private void Eventlog_Display(object sender, ElapsedEventArgs e)
        {
            if (Define.bLoadPortOpAlmEvent)
            {
                Alarmlog_File_Read("LoadPort");
            }

            if (Define.bRobotOpAlmEvent)
            {
                Alarmlog_File_Read("Robot");
            }

            if (Define.bAlignerOpAlmEvent)
            {
                Alarmlog_File_Read("Aligner");
            }

            if (Define.bPMOpAlmEvent)
            {
                Alarmlog_File_Read("PM");
            }
        }

        private void Alarmlog_File_Read(string ModuleName)
        {
            if (Define.bLoadPortOpAlmEvent)
            {
                Define.bLoadPortOpAlmEvent = false;
            }

            if (Define.bRobotOpAlmEvent)
            {
                Define.bRobotOpAlmEvent = false;
            }

            if (Define.bAlignerOpAlmEvent)
            {
                Define.bAlignerOpAlmEvent = false;
            }

            if (Define.bPMOpAlmEvent)
            {
                Define.bPMOpAlmEvent = false;
            }

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
                                if (ModuleName == "LoadPort")
                                {
                                    label_LoadPortAlarm.Text = sVal;
                                }
                                else if (ModuleName == "Robot")
                                {
                                    label_RobotAlarm.Text = sVal;
                                }
                                else if (ModuleName == "Aligner")
                                {
                                    label_AlignerAlarm.Text = sVal;
                                }
                                else if (ModuleName == "PM")
                                {
                                    label_PMAlarm.Text = sVal;
                                }
                            }));
                        }
                    }
                }
            }
            catch (IOException)
            {

            }
        }
    }
}
