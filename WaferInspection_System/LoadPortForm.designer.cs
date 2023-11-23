
namespace WaferInspection_System
{
    partial class LoadPortForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEventLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Alarm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadPortType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LoadPortMappSts = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LoadPortMappWaitPosition = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LoadPortDockPosition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LoadPortElevatorPosition = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LoadPortWaferProtrusion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LoadPortDoorPosition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LoadPortAdsorptionSts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoadPortDoorLatchPosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LoadPortClampPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LoadPortContainerSts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadPortErrorCode01 = new System.Windows.Forms.TextBox();
            this.LoadPortErrorCode10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoadPortOperationSts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadPortDeviceSts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadPortModeSts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadPortErrorSts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadPort = new System.Windows.Forms.Panel();
            this.LoadPortLED_Presence = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.LoadPortLED_Placement = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.LoadPortLED_Load = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.LoadPortLED_Status1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.LoadPortLED_OperatorAccess1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.LoadPortLED_Unload = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.LoadPortLED_OperatorAccess2 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.LoadPortLED_Status2 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnLPLoadToUnload = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.btnLPUnloadToLoad = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.btnLPForcedOrigin = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.btnLPOrigin = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.btnLPAbort = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.btnLPPause = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnLPResume = new System.Windows.Forms.Button();
            this.btnLPStop = new System.Windows.Forms.Button();
            this.btnLPRetry = new System.Windows.Forms.Button();
            this.btnLPErrorClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.LoadPortLED_Presence.SuspendLayout();
            this.LoadPortLED_Placement.SuspendLayout();
            this.LoadPortLED_Load.SuspendLayout();
            this.LoadPortLED_Status1.SuspendLayout();
            this.LoadPortLED_OperatorAccess1.SuspendLayout();
            this.LoadPortLED_Unload.SuspendLayout();
            this.LoadPortLED_OperatorAccess2.SuspendLayout();
            this.LoadPortLED_Status2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEventLog
            // 
            this.listBoxEventLog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventLog.FormattingEnabled = true;
            this.listBoxEventLog.ItemHeight = 17;
            this.listBoxEventLog.Location = new System.Drawing.Point(12, 759);
            this.listBoxEventLog.Name = "listBoxEventLog";
            this.listBoxEventLog.Size = new System.Drawing.Size(1148, 55);
            this.listBoxEventLog.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 47);
            this.label1.TabIndex = 272;
            this.label1.Text = "Load Port";
            // 
            // label_Alarm
            // 
            this.label_Alarm.AutoSize = true;
            this.label_Alarm.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alarm.ForeColor = System.Drawing.Color.Red;
            this.label_Alarm.Location = new System.Drawing.Point(6, 47);
            this.label_Alarm.Name = "label_Alarm";
            this.label_Alarm.Size = new System.Drawing.Size(34, 32);
            this.label_Alarm.TabIndex = 323;
            this.label_Alarm.Text = "--";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.LoadPortType);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.LoadPortMappSts);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.LoadPortMappWaitPosition);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.LoadPortDockPosition);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.LoadPortElevatorPosition);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LoadPortWaferProtrusion);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.LoadPortDoorPosition);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LoadPortAdsorptionSts);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LoadPortDoorLatchPosition);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LoadPortClampPosition);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LoadPortContainerSts);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LoadPortErrorCode01);
            this.groupBox1.Controls.Add(this.LoadPortErrorCode10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LoadPortOperationSts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LoadPortDeviceSts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LoadPortModeSts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LoadPortErrorSts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 671);
            this.groupBox1.TabIndex = 440;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load port status";
            // 
            // LoadPortType
            // 
            this.LoadPortType.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortType.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortType.Location = new System.Drawing.Point(135, 432);
            this.LoadPortType.Name = "LoadPortType";
            this.LoadPortType.ReadOnly = true;
            this.LoadPortType.Size = new System.Drawing.Size(142, 25);
            this.LoadPortType.TabIndex = 448;
            this.LoadPortType.TabStop = false;
            this.LoadPortType.Tag = "50";
            this.LoadPortType.Text = "--";
            this.LoadPortType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 435);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 447;
            this.label17.Text = "Type";
            // 
            // LoadPortMappSts
            // 
            this.LoadPortMappSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortMappSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortMappSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortMappSts.Location = new System.Drawing.Point(135, 401);
            this.LoadPortMappSts.Name = "LoadPortMappSts";
            this.LoadPortMappSts.ReadOnly = true;
            this.LoadPortMappSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortMappSts.TabIndex = 446;
            this.LoadPortMappSts.TabStop = false;
            this.LoadPortMappSts.Tag = "50";
            this.LoadPortMappSts.Text = "--";
            this.LoadPortMappSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 404);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 17);
            this.label16.TabIndex = 445;
            this.label16.Text = "Mapping Status";
            // 
            // LoadPortMappWaitPosition
            // 
            this.LoadPortMappWaitPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortMappWaitPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortMappWaitPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortMappWaitPosition.Location = new System.Drawing.Point(135, 370);
            this.LoadPortMappWaitPosition.Name = "LoadPortMappWaitPosition";
            this.LoadPortMappWaitPosition.ReadOnly = true;
            this.LoadPortMappWaitPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortMappWaitPosition.TabIndex = 444;
            this.LoadPortMappWaitPosition.TabStop = false;
            this.LoadPortMappWaitPosition.Tag = "50";
            this.LoadPortMappWaitPosition.Text = "--";
            this.LoadPortMappWaitPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 17);
            this.label15.TabIndex = 443;
            this.label15.Text = "Mapp Wait Position";
            // 
            // LoadPortDockPosition
            // 
            this.LoadPortDockPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortDockPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortDockPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortDockPosition.Location = new System.Drawing.Point(135, 339);
            this.LoadPortDockPosition.Name = "LoadPortDockPosition";
            this.LoadPortDockPosition.ReadOnly = true;
            this.LoadPortDockPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortDockPosition.TabIndex = 442;
            this.LoadPortDockPosition.TabStop = false;
            this.LoadPortDockPosition.Tag = "50";
            this.LoadPortDockPosition.Text = "--";
            this.LoadPortDockPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 441;
            this.label14.Text = "Dock position";
            // 
            // LoadPortElevatorPosition
            // 
            this.LoadPortElevatorPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortElevatorPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortElevatorPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortElevatorPosition.Location = new System.Drawing.Point(135, 308);
            this.LoadPortElevatorPosition.Name = "LoadPortElevatorPosition";
            this.LoadPortElevatorPosition.ReadOnly = true;
            this.LoadPortElevatorPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortElevatorPosition.TabIndex = 440;
            this.LoadPortElevatorPosition.TabStop = false;
            this.LoadPortElevatorPosition.Tag = "50";
            this.LoadPortElevatorPosition.Text = "--";
            this.LoadPortElevatorPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 439;
            this.label13.Text = "Elevator position";
            // 
            // LoadPortWaferProtrusion
            // 
            this.LoadPortWaferProtrusion.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortWaferProtrusion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortWaferProtrusion.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortWaferProtrusion.Location = new System.Drawing.Point(135, 277);
            this.LoadPortWaferProtrusion.Name = "LoadPortWaferProtrusion";
            this.LoadPortWaferProtrusion.ReadOnly = true;
            this.LoadPortWaferProtrusion.Size = new System.Drawing.Size(142, 25);
            this.LoadPortWaferProtrusion.TabIndex = 438;
            this.LoadPortWaferProtrusion.TabStop = false;
            this.LoadPortWaferProtrusion.Tag = "50";
            this.LoadPortWaferProtrusion.Text = "--";
            this.LoadPortWaferProtrusion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 437;
            this.label12.Text = "Wafer Protrusion";
            // 
            // LoadPortDoorPosition
            // 
            this.LoadPortDoorPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortDoorPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortDoorPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortDoorPosition.Location = new System.Drawing.Point(135, 246);
            this.LoadPortDoorPosition.Name = "LoadPortDoorPosition";
            this.LoadPortDoorPosition.ReadOnly = true;
            this.LoadPortDoorPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortDoorPosition.TabIndex = 436;
            this.LoadPortDoorPosition.TabStop = false;
            this.LoadPortDoorPosition.Tag = "50";
            this.LoadPortDoorPosition.Text = "--";
            this.LoadPortDoorPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 435;
            this.label11.Text = "Door position";
            // 
            // LoadPortAdsorptionSts
            // 
            this.LoadPortAdsorptionSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortAdsorptionSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortAdsorptionSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortAdsorptionSts.Location = new System.Drawing.Point(135, 215);
            this.LoadPortAdsorptionSts.Name = "LoadPortAdsorptionSts";
            this.LoadPortAdsorptionSts.ReadOnly = true;
            this.LoadPortAdsorptionSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortAdsorptionSts.TabIndex = 434;
            this.LoadPortAdsorptionSts.TabStop = false;
            this.LoadPortAdsorptionSts.Tag = "50";
            this.LoadPortAdsorptionSts.Text = "--";
            this.LoadPortAdsorptionSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 433;
            this.label10.Text = "Adsorption Status";
            // 
            // LoadPortDoorLatchPosition
            // 
            this.LoadPortDoorLatchPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortDoorLatchPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortDoorLatchPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortDoorLatchPosition.Location = new System.Drawing.Point(135, 184);
            this.LoadPortDoorLatchPosition.Name = "LoadPortDoorLatchPosition";
            this.LoadPortDoorLatchPosition.ReadOnly = true;
            this.LoadPortDoorLatchPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortDoorLatchPosition.TabIndex = 432;
            this.LoadPortDoorLatchPosition.TabStop = false;
            this.LoadPortDoorLatchPosition.Tag = "50";
            this.LoadPortDoorLatchPosition.Text = "--";
            this.LoadPortDoorLatchPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 431;
            this.label9.Text = "DoorLatch position";
            // 
            // LoadPortClampPosition
            // 
            this.LoadPortClampPosition.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortClampPosition.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortClampPosition.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortClampPosition.Location = new System.Drawing.Point(135, 153);
            this.LoadPortClampPosition.Name = "LoadPortClampPosition";
            this.LoadPortClampPosition.ReadOnly = true;
            this.LoadPortClampPosition.Size = new System.Drawing.Size(142, 25);
            this.LoadPortClampPosition.TabIndex = 430;
            this.LoadPortClampPosition.TabStop = false;
            this.LoadPortClampPosition.Tag = "50";
            this.LoadPortClampPosition.Text = "--";
            this.LoadPortClampPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 429;
            this.label8.Text = "Clamp position";
            // 
            // LoadPortContainerSts
            // 
            this.LoadPortContainerSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortContainerSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortContainerSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortContainerSts.Location = new System.Drawing.Point(135, 122);
            this.LoadPortContainerSts.Name = "LoadPortContainerSts";
            this.LoadPortContainerSts.ReadOnly = true;
            this.LoadPortContainerSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortContainerSts.TabIndex = 428;
            this.LoadPortContainerSts.TabStop = false;
            this.LoadPortContainerSts.Tag = "50";
            this.LoadPortContainerSts.Text = "--";
            this.LoadPortContainerSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 427;
            this.label7.Text = "Container status";
            // 
            // LoadPortErrorCode01
            // 
            this.LoadPortErrorCode01.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortErrorCode01.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortErrorCode01.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortErrorCode01.Location = new System.Drawing.Point(207, 494);
            this.LoadPortErrorCode01.Name = "LoadPortErrorCode01";
            this.LoadPortErrorCode01.ReadOnly = true;
            this.LoadPortErrorCode01.Size = new System.Drawing.Size(70, 25);
            this.LoadPortErrorCode01.TabIndex = 426;
            this.LoadPortErrorCode01.TabStop = false;
            this.LoadPortErrorCode01.Tag = "50";
            this.LoadPortErrorCode01.Text = "--";
            this.LoadPortErrorCode01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadPortErrorCode10
            // 
            this.LoadPortErrorCode10.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortErrorCode10.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortErrorCode10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortErrorCode10.Location = new System.Drawing.Point(135, 494);
            this.LoadPortErrorCode10.Name = "LoadPortErrorCode10";
            this.LoadPortErrorCode10.ReadOnly = true;
            this.LoadPortErrorCode10.Size = new System.Drawing.Size(70, 25);
            this.LoadPortErrorCode10.TabIndex = 425;
            this.LoadPortErrorCode10.TabStop = false;
            this.LoadPortErrorCode10.Tag = "50";
            this.LoadPortErrorCode10.Text = "--";
            this.LoadPortErrorCode10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 424;
            this.label6.Text = "Error code";
            // 
            // LoadPortOperationSts
            // 
            this.LoadPortOperationSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortOperationSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortOperationSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortOperationSts.Location = new System.Drawing.Point(135, 91);
            this.LoadPortOperationSts.Name = "LoadPortOperationSts";
            this.LoadPortOperationSts.ReadOnly = true;
            this.LoadPortOperationSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortOperationSts.TabIndex = 423;
            this.LoadPortOperationSts.TabStop = false;
            this.LoadPortOperationSts.Tag = "50";
            this.LoadPortOperationSts.Text = "--";
            this.LoadPortOperationSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 422;
            this.label5.Text = "Operation status";
            // 
            // LoadPortDeviceSts
            // 
            this.LoadPortDeviceSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortDeviceSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortDeviceSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortDeviceSts.Location = new System.Drawing.Point(135, 60);
            this.LoadPortDeviceSts.Name = "LoadPortDeviceSts";
            this.LoadPortDeviceSts.ReadOnly = true;
            this.LoadPortDeviceSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortDeviceSts.TabIndex = 421;
            this.LoadPortDeviceSts.TabStop = false;
            this.LoadPortDeviceSts.Tag = "50";
            this.LoadPortDeviceSts.Text = "--";
            this.LoadPortDeviceSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 420;
            this.label4.Text = "Device status";
            // 
            // LoadPortModeSts
            // 
            this.LoadPortModeSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortModeSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortModeSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortModeSts.Location = new System.Drawing.Point(135, 29);
            this.LoadPortModeSts.Name = "LoadPortModeSts";
            this.LoadPortModeSts.ReadOnly = true;
            this.LoadPortModeSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortModeSts.TabIndex = 419;
            this.LoadPortModeSts.TabStop = false;
            this.LoadPortModeSts.Tag = "50";
            this.LoadPortModeSts.Text = "--";
            this.LoadPortModeSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 418;
            this.label3.Text = "Mode";
            // 
            // LoadPortErrorSts
            // 
            this.LoadPortErrorSts.BackColor = System.Drawing.Color.Ivory;
            this.LoadPortErrorSts.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadPortErrorSts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPortErrorSts.Location = new System.Drawing.Point(135, 463);
            this.LoadPortErrorSts.Name = "LoadPortErrorSts";
            this.LoadPortErrorSts.ReadOnly = true;
            this.LoadPortErrorSts.Size = new System.Drawing.Size(142, 25);
            this.LoadPortErrorSts.TabIndex = 417;
            this.LoadPortErrorSts.TabStop = false;
            this.LoadPortErrorSts.Tag = "50";
            this.LoadPortErrorSts.Text = "--";
            this.LoadPortErrorSts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 416;
            this.label2.Text = "Error";
            // 
            // LoadPort
            // 
            this.LoadPort.BackColor = System.Drawing.Color.Transparent;
            this.LoadPort.BackgroundImage = global::WaferInspection_System.Properties.Resources.LoadPort;
            this.LoadPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadPort.Location = new System.Drawing.Point(393, 168);
            this.LoadPort.Name = "LoadPort";
            this.LoadPort.Size = new System.Drawing.Size(354, 400);
            this.LoadPort.TabIndex = 441;
            // 
            // LoadPortLED_Presence
            // 
            this.LoadPortLED_Presence.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Presence.Controls.Add(this.label19);
            this.LoadPortLED_Presence.Location = new System.Drawing.Point(393, 138);
            this.LoadPortLED_Presence.Name = "LoadPortLED_Presence";
            this.LoadPortLED_Presence.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Presence.TabIndex = 442;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 17);
            this.label19.TabIndex = 453;
            this.label19.Text = "Presence";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_Placement
            // 
            this.LoadPortLED_Placement.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Placement.Controls.Add(this.label18);
            this.LoadPortLED_Placement.Location = new System.Drawing.Point(483, 138);
            this.LoadPortLED_Placement.Name = "LoadPortLED_Placement";
            this.LoadPortLED_Placement.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Placement.TabIndex = 444;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 17);
            this.label18.TabIndex = 454;
            this.label18.Text = "Placement";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_Load
            // 
            this.LoadPortLED_Load.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Load.Controls.Add(this.label20);
            this.LoadPortLED_Load.Location = new System.Drawing.Point(573, 138);
            this.LoadPortLED_Load.Name = "LoadPortLED_Load";
            this.LoadPortLED_Load.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Load.TabIndex = 446;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 17);
            this.label20.TabIndex = 455;
            this.label20.Text = "Load";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_Status1
            // 
            this.LoadPortLED_Status1.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Status1.Controls.Add(this.label24);
            this.LoadPortLED_Status1.Location = new System.Drawing.Point(483, 574);
            this.LoadPortLED_Status1.Name = "LoadPortLED_Status1";
            this.LoadPortLED_Status1.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Status1.TabIndex = 449;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(6, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 17);
            this.label24.TabIndex = 457;
            this.label24.Text = "Status1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_OperatorAccess1
            // 
            this.LoadPortLED_OperatorAccess1.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_OperatorAccess1.Controls.Add(this.label22);
            this.LoadPortLED_OperatorAccess1.Location = new System.Drawing.Point(573, 574);
            this.LoadPortLED_OperatorAccess1.Name = "LoadPortLED_OperatorAccess1";
            this.LoadPortLED_OperatorAccess1.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_OperatorAccess1.TabIndex = 448;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(6, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 17);
            this.label22.TabIndex = 456;
            this.label22.Text = "OP Access";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_Unload
            // 
            this.LoadPortLED_Unload.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Unload.Controls.Add(this.label21);
            this.LoadPortLED_Unload.Location = new System.Drawing.Point(663, 138);
            this.LoadPortLED_Unload.Name = "LoadPortLED_Unload";
            this.LoadPortLED_Unload.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Unload.TabIndex = 447;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(6, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 17);
            this.label21.TabIndex = 456;
            this.label21.Text = "Unload";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_OperatorAccess2
            // 
            this.LoadPortLED_OperatorAccess2.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_OperatorAccess2.Controls.Add(this.label23);
            this.LoadPortLED_OperatorAccess2.Location = new System.Drawing.Point(573, 604);
            this.LoadPortLED_OperatorAccess2.Name = "LoadPortLED_OperatorAccess2";
            this.LoadPortLED_OperatorAccess2.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_OperatorAccess2.TabIndex = 451;
            this.LoadPortLED_OperatorAccess2.Visible = false;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(6, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 17);
            this.label23.TabIndex = 457;
            this.label23.Text = "OP Access";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPortLED_Status2
            // 
            this.LoadPortLED_Status2.BackColor = System.Drawing.Color.Silver;
            this.LoadPortLED_Status2.Controls.Add(this.label25);
            this.LoadPortLED_Status2.Location = new System.Drawing.Point(483, 604);
            this.LoadPortLED_Status2.Name = "LoadPortLED_Status2";
            this.LoadPortLED_Status2.Size = new System.Drawing.Size(84, 24);
            this.LoadPortLED_Status2.TabIndex = 450;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(6, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 17);
            this.label25.TabIndex = 457;
            this.label25.Text = "Status2";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.btnLPLoadToUnload);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.btnLPUnloadToLoad);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.btnLPForcedOrigin);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.btnLPOrigin);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.btnLPAbort);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.btnLPPause);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.btnLPResume);
            this.groupBox2.Controls.Add(this.btnLPStop);
            this.groupBox2.Controls.Add(this.btnLPRetry);
            this.groupBox2.Controls.Add(this.btnLPErrorClear);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(819, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 671);
            this.groupBox2.TabIndex = 452;
            this.groupBox2.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(98, 416);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(181, 13);
            this.label34.TabIndex = 478;
            this.label34.Text = "[로드 상태에서 언로드 상태로 이동]";
            // 
            // btnLPLoadToUnload
            // 
            this.btnLPLoadToUnload.BackColor = System.Drawing.Color.White;
            this.btnLPLoadToUnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPLoadToUnload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPLoadToUnload.FlatAppearance.BorderSize = 0;
            this.btnLPLoadToUnload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPLoadToUnload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPLoadToUnload.ForeColor = System.Drawing.Color.Navy;
            this.btnLPLoadToUnload.Location = new System.Drawing.Point(6, 404);
            this.btnLPLoadToUnload.Name = "btnLPLoadToUnload";
            this.btnLPLoadToUnload.Size = new System.Drawing.Size(86, 32);
            this.btnLPLoadToUnload.TabIndex = 477;
            this.btnLPLoadToUnload.Tag = "0";
            this.btnLPLoadToUnload.Text = "Unload";
            this.btnLPLoadToUnload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPLoadToUnload.UseVisualStyleBackColor = false;
            this.btnLPLoadToUnload.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(98, 378);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(181, 13);
            this.label33.TabIndex = 476;
            this.label33.Text = "[언로드 상태에서 로드 상태로 이동]";
            // 
            // btnLPUnloadToLoad
            // 
            this.btnLPUnloadToLoad.BackColor = System.Drawing.Color.White;
            this.btnLPUnloadToLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPUnloadToLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPUnloadToLoad.FlatAppearance.BorderSize = 0;
            this.btnLPUnloadToLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPUnloadToLoad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPUnloadToLoad.ForeColor = System.Drawing.Color.Navy;
            this.btnLPUnloadToLoad.Location = new System.Drawing.Point(6, 366);
            this.btnLPUnloadToLoad.Name = "btnLPUnloadToLoad";
            this.btnLPUnloadToLoad.Size = new System.Drawing.Size(86, 32);
            this.btnLPUnloadToLoad.TabIndex = 475;
            this.btnLPUnloadToLoad.Tag = "0";
            this.btnLPUnloadToLoad.Text = "Load";
            this.btnLPUnloadToLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPUnloadToLoad.UseVisualStyleBackColor = false;
            this.btnLPUnloadToLoad.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(98, 320);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(123, 13);
            this.label32.TabIndex = 474;
            this.label32.Text = "[초기 위치로 강제 이동]";
            // 
            // btnLPForcedOrigin
            // 
            this.btnLPForcedOrigin.BackColor = System.Drawing.Color.White;
            this.btnLPForcedOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPForcedOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPForcedOrigin.FlatAppearance.BorderSize = 0;
            this.btnLPForcedOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPForcedOrigin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPForcedOrigin.ForeColor = System.Drawing.Color.Navy;
            this.btnLPForcedOrigin.Location = new System.Drawing.Point(6, 308);
            this.btnLPForcedOrigin.Name = "btnLPForcedOrigin";
            this.btnLPForcedOrigin.Size = new System.Drawing.Size(86, 32);
            this.btnLPForcedOrigin.TabIndex = 473;
            this.btnLPForcedOrigin.Tag = "0";
            this.btnLPForcedOrigin.Text = "F.Origin";
            this.btnLPForcedOrigin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPForcedOrigin.UseVisualStyleBackColor = false;
            this.btnLPForcedOrigin.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(98, 284);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(98, 13);
            this.label31.TabIndex = 472;
            this.label31.Text = "[초기 위치로 이동]";
            // 
            // btnLPOrigin
            // 
            this.btnLPOrigin.BackColor = System.Drawing.Color.White;
            this.btnLPOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPOrigin.FlatAppearance.BorderSize = 0;
            this.btnLPOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPOrigin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPOrigin.ForeColor = System.Drawing.Color.Navy;
            this.btnLPOrigin.Location = new System.Drawing.Point(6, 270);
            this.btnLPOrigin.Name = "btnLPOrigin";
            this.btnLPOrigin.Size = new System.Drawing.Size(86, 32);
            this.btnLPOrigin.TabIndex = 471;
            this.btnLPOrigin.Tag = "0";
            this.btnLPOrigin.Text = "Origin";
            this.btnLPOrigin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPOrigin.UseVisualStyleBackColor = false;
            this.btnLPOrigin.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(98, 224);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(238, 13);
            this.label30.TabIndex = 470;
            this.label30.Text = "[동작 정지 시 실행 가능(계속 동작/Retry 불가)]";
            // 
            // btnLPAbort
            // 
            this.btnLPAbort.BackColor = System.Drawing.Color.White;
            this.btnLPAbort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPAbort.FlatAppearance.BorderSize = 0;
            this.btnLPAbort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPAbort.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPAbort.ForeColor = System.Drawing.Color.Red;
            this.btnLPAbort.Location = new System.Drawing.Point(6, 212);
            this.btnLPAbort.Name = "btnLPAbort";
            this.btnLPAbort.Size = new System.Drawing.Size(86, 32);
            this.btnLPAbort.TabIndex = 469;
            this.btnLPAbort.Tag = "";
            this.btnLPAbort.Text = "Abort";
            this.btnLPAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPAbort.UseVisualStyleBackColor = false;
            this.btnLPAbort.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(98, 187);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 13);
            this.label29.TabIndex = 468;
            this.label29.Text = "[동작 정지(계속 동작 가능)]";
            // 
            // btnLPPause
            // 
            this.btnLPPause.BackColor = System.Drawing.Color.White;
            this.btnLPPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPPause.FlatAppearance.BorderSize = 0;
            this.btnLPPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPPause.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPPause.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLPPause.Location = new System.Drawing.Point(6, 174);
            this.btnLPPause.Name = "btnLPPause";
            this.btnLPPause.Size = new System.Drawing.Size(86, 32);
            this.btnLPPause.TabIndex = 467;
            this.btnLPPause.Tag = "";
            this.btnLPPause.Text = "Pause";
            this.btnLPPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPPause.UseVisualStyleBackColor = false;
            this.btnLPPause.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(98, 148);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 13);
            this.label28.TabIndex = 466;
            this.label28.Text = "[동작 정지(계속 동작 불가)]";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(98, 111);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(142, 13);
            this.label27.TabIndex = 465;
            this.label27.Text = "[동작 정지(계속 동작 불가)]";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(98, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(203, 13);
            this.label26.TabIndex = 464;
            this.label26.Text = "[동작 정지(계속 동작 불가)시 실행 가능]";
            // 
            // btnLPResume
            // 
            this.btnLPResume.BackColor = System.Drawing.Color.White;
            this.btnLPResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPResume.FlatAppearance.BorderSize = 0;
            this.btnLPResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPResume.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPResume.ForeColor = System.Drawing.Color.Blue;
            this.btnLPResume.Location = new System.Drawing.Point(6, 136);
            this.btnLPResume.Name = "btnLPResume";
            this.btnLPResume.Size = new System.Drawing.Size(86, 32);
            this.btnLPResume.TabIndex = 463;
            this.btnLPResume.Tag = "";
            this.btnLPResume.Text = "Resume";
            this.btnLPResume.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPResume.UseVisualStyleBackColor = false;
            this.btnLPResume.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // btnLPStop
            // 
            this.btnLPStop.BackColor = System.Drawing.Color.White;
            this.btnLPStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPStop.FlatAppearance.BorderSize = 0;
            this.btnLPStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPStop.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPStop.ForeColor = System.Drawing.Color.Red;
            this.btnLPStop.Location = new System.Drawing.Point(6, 98);
            this.btnLPStop.Name = "btnLPStop";
            this.btnLPStop.Size = new System.Drawing.Size(86, 32);
            this.btnLPStop.TabIndex = 458;
            this.btnLPStop.Tag = "";
            this.btnLPStop.Text = "Stop";
            this.btnLPStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPStop.UseVisualStyleBackColor = false;
            this.btnLPStop.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // btnLPRetry
            // 
            this.btnLPRetry.BackColor = System.Drawing.Color.White;
            this.btnLPRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPRetry.FlatAppearance.BorderSize = 0;
            this.btnLPRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPRetry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPRetry.ForeColor = System.Drawing.Color.Green;
            this.btnLPRetry.Location = new System.Drawing.Point(6, 60);
            this.btnLPRetry.Name = "btnLPRetry";
            this.btnLPRetry.Size = new System.Drawing.Size(86, 32);
            this.btnLPRetry.TabIndex = 457;
            this.btnLPRetry.Tag = "";
            this.btnLPRetry.Text = "Retry";
            this.btnLPRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPRetry.UseVisualStyleBackColor = false;
            this.btnLPRetry.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // btnLPErrorClear
            // 
            this.btnLPErrorClear.BackColor = System.Drawing.Color.White;
            this.btnLPErrorClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLPErrorClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPErrorClear.FlatAppearance.BorderSize = 0;
            this.btnLPErrorClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLPErrorClear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPErrorClear.ForeColor = System.Drawing.Color.Navy;
            this.btnLPErrorClear.Location = new System.Drawing.Point(6, 22);
            this.btnLPErrorClear.Name = "btnLPErrorClear";
            this.btnLPErrorClear.Size = new System.Drawing.Size(86, 32);
            this.btnLPErrorClear.TabIndex = 456;
            this.btnLPErrorClear.Tag = "";
            this.btnLPErrorClear.Text = "E-Clear";
            this.btnLPErrorClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLPErrorClear.UseVisualStyleBackColor = false;
            this.btnLPErrorClear.Click += new System.EventHandler(this.LoadPort_Control_Click);
            // 
            // LoadPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LoadPortLED_OperatorAccess2);
            this.Controls.Add(this.LoadPortLED_Status2);
            this.Controls.Add(this.LoadPortLED_Status1);
            this.Controls.Add(this.LoadPortLED_OperatorAccess1);
            this.Controls.Add(this.LoadPortLED_Unload);
            this.Controls.Add(this.LoadPortLED_Load);
            this.Controls.Add(this.LoadPortLED_Placement);
            this.Controls.Add(this.LoadPortLED_Presence);
            this.Controls.Add(this.LoadPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Alarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxEventLog);
            this.Name = "LoadPortForm";
            this.Size = new System.Drawing.Size(1172, 824);
            this.Load += new System.EventHandler(this.LoadPortForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LoadPortLED_Presence.ResumeLayout(false);
            this.LoadPortLED_Placement.ResumeLayout(false);
            this.LoadPortLED_Load.ResumeLayout(false);
            this.LoadPortLED_Status1.ResumeLayout(false);
            this.LoadPortLED_OperatorAccess1.ResumeLayout(false);
            this.LoadPortLED_Unload.ResumeLayout(false);
            this.LoadPortLED_OperatorAccess2.ResumeLayout(false);
            this.LoadPortLED_Status2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxEventLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Alarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LoadPortErrorSts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoadPort;
        private System.Windows.Forms.TextBox LoadPortModeSts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoadPortContainerSts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LoadPortErrorCode01;
        private System.Windows.Forms.TextBox LoadPortErrorCode10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoadPortOperationSts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoadPortDeviceSts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoadPortDoorLatchPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LoadPortClampPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LoadPortAdsorptionSts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LoadPortType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox LoadPortMappSts;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox LoadPortMappWaitPosition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LoadPortDockPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox LoadPortElevatorPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LoadPortWaferProtrusion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LoadPortDoorPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel LoadPortLED_Presence;
        private System.Windows.Forms.Panel LoadPortLED_Placement;
        private System.Windows.Forms.Panel LoadPortLED_Load;
        private System.Windows.Forms.Panel LoadPortLED_Status1;
        private System.Windows.Forms.Panel LoadPortLED_OperatorAccess1;
        private System.Windows.Forms.Panel LoadPortLED_Unload;
        private System.Windows.Forms.Panel LoadPortLED_OperatorAccess2;
        private System.Windows.Forms.Panel LoadPortLED_Status2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLPStop;
        private System.Windows.Forms.Button btnLPRetry;
        private System.Windows.Forms.Button btnLPErrorClear;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnLPResume;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnLPAbort;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnLPPause;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnLPOrigin;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnLPForcedOrigin;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnLPUnloadToLoad;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnLPLoadToUnload;
    }
}
