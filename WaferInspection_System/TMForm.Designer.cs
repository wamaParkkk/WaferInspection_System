
namespace WaferInspection_System
{
    partial class TMForm
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
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.listBoxEventLog = new System.Windows.Forms.ListBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TargetSlotNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SourceSlotNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.TargetStage = new System.Windows.Forms.ComboBox();
            this.SourceStage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6213 = new System.Windows.Forms.Label();
            this.label_Alarm = new System.Windows.Forms.Label();
            this.TableUpSns = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PM1BrushFwdSns = new System.Windows.Forms.Label();
            this.PM1BrushBwdSns = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.Robot = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRobotPlace = new System.Windows.Forms.Button();
            this.btnRobotPick = new System.Windows.Forms.Button();
            this.RobotErrorStatus1 = new System.Windows.Forms.TextBox();
            this.RobotErrorStatus10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RobotStage1 = new System.Windows.Forms.TextBox();
            this.RobotStage10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RobotPauseStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RobotZaxisStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RobotArmStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RobotBusyStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RobotInitStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModuleSlotNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ModuleStage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRobotHome = new System.Windows.Forms.Button();
            this.btnRobotReset = new System.Windows.Forms.Button();
            this.btnRobotMapping = new System.Windows.Forms.Button();
            this.btnRobotMapSnsPower = new System.Windows.Forms.Button();
            this.btnRobotStop = new System.Windows.Forms.Button();
            this.btnRobotResume = new System.Windows.Forms.Button();
            this.btnRobotPause = new System.Windows.Forms.Button();
            this.btnRobotEMGStop = new System.Windows.Forms.Button();
            this.btnRobotVacuum = new System.Windows.Forms.Button();
            this.btnRobotDown = new System.Windows.Forms.Button();
            this.btnRobotUp = new System.Windows.Forms.Button();
            this.btnRobotRotation = new System.Windows.Forms.Button();
            this.btnRobotExtend = new System.Windows.Forms.Button();
            this.btnRobotRetract = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.White;
            this.btnPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlace.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.ForeColor = System.Drawing.Color.Navy;
            this.btnPlace.Location = new System.Drawing.Point(124, 304);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(112, 42);
            this.btnPlace.TabIndex = 27;
            this.btnPlace.Tag = "";
            this.btnPlace.Text = "Place";
            this.btnPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(124, 352);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 42);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPick
            // 
            this.btnPick.BackColor = System.Drawing.Color.White;
            this.btnPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPick.FlatAppearance.BorderSize = 0;
            this.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPick.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.ForeColor = System.Drawing.Color.Navy;
            this.btnPick.Location = new System.Drawing.Point(6, 304);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(112, 42);
            this.btnPick.TabIndex = 23;
            this.btnPick.Tag = "";
            this.btnPick.Text = "Pick";
            this.btnPick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
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
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Navy;
            this.label35.Location = new System.Drawing.Point(525, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 47);
            this.label35.TabIndex = 272;
            this.label35.Text = "TM";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.TargetSlotNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SourceSlotNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPlace);
            this.groupBox2.Controls.Add(this.TargetStage);
            this.groupBox2.Controls.Add(this.SourceStage);
            this.groupBox2.Controls.Add(this.btnPick);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6213);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(755, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 400);
            this.groupBox2.TabIndex = 305;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual moving";
            // 
            // TargetSlotNo
            // 
            this.TargetSlotNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetSlotNo.FormattingEnabled = true;
            this.TargetSlotNo.Location = new System.Drawing.Point(278, 85);
            this.TargetSlotNo.Name = "TargetSlotNo";
            this.TargetSlotNo.Size = new System.Drawing.Size(121, 28);
            this.TargetSlotNo.TabIndex = 275;
            this.TargetSlotNo.DropDown += new System.EventHandler(this.TargetSlotNo_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 274;
            this.label3.Text = "Slot no";
            // 
            // SourceSlotNo
            // 
            this.SourceSlotNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceSlotNo.FormattingEnabled = true;
            this.SourceSlotNo.Location = new System.Drawing.Point(68, 85);
            this.SourceSlotNo.Name = "SourceSlotNo";
            this.SourceSlotNo.Size = new System.Drawing.Size(121, 28);
            this.SourceSlotNo.TabIndex = 273;
            this.SourceSlotNo.DropDown += new System.EventHandler(this.SourceSlotNo_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 272;
            this.label2.Text = "Slot no";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Navy;
            this.btnHome.Location = new System.Drawing.Point(6, 352);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 42);
            this.btnHome.TabIndex = 271;
            this.btnHome.Tag = "";
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.White;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMove.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Navy;
            this.btnMove.Location = new System.Drawing.Point(242, 304);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(112, 42);
            this.btnMove.TabIndex = 270;
            this.btnMove.Tag = "";
            this.btnMove.Text = "Move";
            this.btnMove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // TargetStage
            // 
            this.TargetStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetStage.FormattingEnabled = true;
            this.TargetStage.Location = new System.Drawing.Point(278, 36);
            this.TargetStage.Name = "TargetStage";
            this.TargetStage.Size = new System.Drawing.Size(121, 28);
            this.TargetStage.TabIndex = 269;
            this.TargetStage.DropDown += new System.EventHandler(this.TargetStage_DropDown);
            // 
            // SourceStage
            // 
            this.SourceStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceStage.FormattingEnabled = true;
            this.SourceStage.Location = new System.Drawing.Point(68, 36);
            this.SourceStage.Name = "SourceStage";
            this.SourceStage.Size = new System.Drawing.Size(121, 28);
            this.SourceStage.TabIndex = 268;
            this.SourceStage.DropDown += new System.EventHandler(this.SourceStage_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 266;
            this.label1.Text = "Target";
            // 
            // label6213
            // 
            this.label6213.AutoSize = true;
            this.label6213.Location = new System.Drawing.Point(6, 39);
            this.label6213.Name = "label6213";
            this.label6213.Size = new System.Drawing.Size(56, 20);
            this.label6213.TabIndex = 265;
            this.label6213.Text = "Source";
            // 
            // label_Alarm
            // 
            this.label_Alarm.AutoSize = true;
            this.label_Alarm.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alarm.ForeColor = System.Drawing.Color.Red;
            this.label_Alarm.Location = new System.Drawing.Point(6, 47);
            this.label_Alarm.Name = "label_Alarm";
            this.label_Alarm.Size = new System.Drawing.Size(34, 32);
            this.label_Alarm.TabIndex = 0;
            this.label_Alarm.Text = "--";
            // 
            // TableUpSns
            // 
            this.TableUpSns.BackColor = System.Drawing.Color.Silver;
            this.TableUpSns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TableUpSns.Location = new System.Drawing.Point(359, 353);
            this.TableUpSns.Name = "TableUpSns";
            this.TableUpSns.Size = new System.Drawing.Size(18, 18);
            this.TableUpSns.TabIndex = 436;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(451, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 437;
            this.label17.Text = "PM (Inspection)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(306, 354);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 15);
            this.label18.TabIndex = 438;
            this.label18.Text = "Aligner";
            // 
            // PM1BrushFwdSns
            // 
            this.PM1BrushFwdSns.BackColor = System.Drawing.Color.Silver;
            this.PM1BrushFwdSns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PM1BrushFwdSns.Location = new System.Drawing.Point(551, 135);
            this.PM1BrushFwdSns.Name = "PM1BrushFwdSns";
            this.PM1BrushFwdSns.Size = new System.Drawing.Size(18, 18);
            this.PM1BrushFwdSns.TabIndex = 427;
            // 
            // PM1BrushBwdSns
            // 
            this.PM1BrushBwdSns.BackColor = System.Drawing.Color.Silver;
            this.PM1BrushBwdSns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PM1BrushBwdSns.Location = new System.Drawing.Point(551, 581);
            this.PM1BrushBwdSns.Name = "PM1BrushBwdSns";
            this.PM1BrushBwdSns.Size = new System.Drawing.Size(18, 18);
            this.PM1BrushBwdSns.TabIndex = 428;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(485, 582);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 15);
            this.label50.TabIndex = 430;
            this.label50.Text = "Load port";
            // 
            // Robot
            // 
            this.Robot.BackColor = System.Drawing.Color.Transparent;
            this.Robot.BackgroundImage = global::WaferInspection_System.Properties.Resources.Robot;
            this.Robot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Robot.Location = new System.Drawing.Point(393, 168);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(330, 400);
            this.Robot.TabIndex = 372;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnRobotPlace);
            this.groupBox1.Controls.Add(this.btnRobotPick);
            this.groupBox1.Controls.Add(this.RobotErrorStatus1);
            this.groupBox1.Controls.Add(this.RobotErrorStatus10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RobotStage1);
            this.groupBox1.Controls.Add(this.RobotStage10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.RobotPauseStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.RobotZaxisStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RobotArmStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.RobotBusyStatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RobotInitStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ModuleSlotNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ModuleStage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRobotHome);
            this.groupBox1.Controls.Add(this.btnRobotReset);
            this.groupBox1.Controls.Add(this.btnRobotMapping);
            this.groupBox1.Controls.Add(this.btnRobotMapSnsPower);
            this.groupBox1.Controls.Add(this.btnRobotStop);
            this.groupBox1.Controls.Add(this.btnRobotResume);
            this.groupBox1.Controls.Add(this.btnRobotPause);
            this.groupBox1.Controls.Add(this.btnRobotEMGStop);
            this.groupBox1.Controls.Add(this.btnRobotVacuum);
            this.groupBox1.Controls.Add(this.btnRobotDown);
            this.groupBox1.Controls.Add(this.btnRobotUp);
            this.groupBox1.Controls.Add(this.btnRobotRotation);
            this.groupBox1.Controls.Add(this.btnRobotExtend);
            this.groupBox1.Controls.Add(this.btnRobotRetract);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 671);
            this.groupBox1.TabIndex = 439;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot control";
            // 
            // btnRobotPlace
            // 
            this.btnRobotPlace.BackColor = System.Drawing.Color.White;
            this.btnRobotPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotPlace.FlatAppearance.BorderSize = 0;
            this.btnRobotPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotPlace.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotPlace.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotPlace.Location = new System.Drawing.Point(98, 519);
            this.btnRobotPlace.Name = "btnRobotPlace";
            this.btnRobotPlace.Size = new System.Drawing.Size(86, 32);
            this.btnRobotPlace.TabIndex = 433;
            this.btnRobotPlace.Tag = "";
            this.btnRobotPlace.Text = "Place";
            this.btnRobotPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotPlace.UseVisualStyleBackColor = false;
            this.btnRobotPlace.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotPick
            // 
            this.btnRobotPick.BackColor = System.Drawing.Color.White;
            this.btnRobotPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotPick.FlatAppearance.BorderSize = 0;
            this.btnRobotPick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotPick.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotPick.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotPick.Location = new System.Drawing.Point(6, 519);
            this.btnRobotPick.Name = "btnRobotPick";
            this.btnRobotPick.Size = new System.Drawing.Size(86, 32);
            this.btnRobotPick.TabIndex = 432;
            this.btnRobotPick.Tag = "";
            this.btnRobotPick.Text = "Pick";
            this.btnRobotPick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotPick.UseVisualStyleBackColor = false;
            this.btnRobotPick.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // RobotErrorStatus1
            // 
            this.RobotErrorStatus1.BackColor = System.Drawing.Color.Ivory;
            this.RobotErrorStatus1.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotErrorStatus1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotErrorStatus1.Location = new System.Drawing.Point(171, 215);
            this.RobotErrorStatus1.Name = "RobotErrorStatus1";
            this.RobotErrorStatus1.ReadOnly = true;
            this.RobotErrorStatus1.Size = new System.Drawing.Size(105, 25);
            this.RobotErrorStatus1.TabIndex = 431;
            this.RobotErrorStatus1.TabStop = false;
            this.RobotErrorStatus1.Tag = "50";
            this.RobotErrorStatus1.Text = "--";
            this.RobotErrorStatus1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RobotErrorStatus10
            // 
            this.RobotErrorStatus10.BackColor = System.Drawing.Color.Ivory;
            this.RobotErrorStatus10.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotErrorStatus10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotErrorStatus10.Location = new System.Drawing.Point(64, 215);
            this.RobotErrorStatus10.Name = "RobotErrorStatus10";
            this.RobotErrorStatus10.ReadOnly = true;
            this.RobotErrorStatus10.Size = new System.Drawing.Size(105, 25);
            this.RobotErrorStatus10.TabIndex = 430;
            this.RobotErrorStatus10.TabStop = false;
            this.RobotErrorStatus10.Tag = "50";
            this.RobotErrorStatus10.Text = "--";
            this.RobotErrorStatus10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 429;
            this.label12.Text = "Error";
            // 
            // RobotStage1
            // 
            this.RobotStage1.BackColor = System.Drawing.Color.Ivory;
            this.RobotStage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotStage1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotStage1.Location = new System.Drawing.Point(171, 184);
            this.RobotStage1.Name = "RobotStage1";
            this.RobotStage1.ReadOnly = true;
            this.RobotStage1.Size = new System.Drawing.Size(105, 25);
            this.RobotStage1.TabIndex = 428;
            this.RobotStage1.TabStop = false;
            this.RobotStage1.Tag = "50";
            this.RobotStage1.Text = "--";
            this.RobotStage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RobotStage10
            // 
            this.RobotStage10.BackColor = System.Drawing.Color.Ivory;
            this.RobotStage10.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotStage10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotStage10.Location = new System.Drawing.Point(64, 184);
            this.RobotStage10.Name = "RobotStage10";
            this.RobotStage10.ReadOnly = true;
            this.RobotStage10.Size = new System.Drawing.Size(105, 25);
            this.RobotStage10.TabIndex = 427;
            this.RobotStage10.TabStop = false;
            this.RobotStage10.Tag = "50";
            this.RobotStage10.Text = "--";
            this.RobotStage10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 426;
            this.label11.Text = "Stage";
            // 
            // RobotPauseStatus
            // 
            this.RobotPauseStatus.BackColor = System.Drawing.Color.Ivory;
            this.RobotPauseStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotPauseStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotPauseStatus.Location = new System.Drawing.Point(64, 153);
            this.RobotPauseStatus.Name = "RobotPauseStatus";
            this.RobotPauseStatus.ReadOnly = true;
            this.RobotPauseStatus.Size = new System.Drawing.Size(212, 25);
            this.RobotPauseStatus.TabIndex = 425;
            this.RobotPauseStatus.TabStop = false;
            this.RobotPauseStatus.Tag = "50";
            this.RobotPauseStatus.Text = "--";
            this.RobotPauseStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 424;
            this.label10.Text = "Pause";
            // 
            // RobotZaxisStatus
            // 
            this.RobotZaxisStatus.BackColor = System.Drawing.Color.Ivory;
            this.RobotZaxisStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotZaxisStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotZaxisStatus.Location = new System.Drawing.Point(64, 122);
            this.RobotZaxisStatus.Name = "RobotZaxisStatus";
            this.RobotZaxisStatus.ReadOnly = true;
            this.RobotZaxisStatus.Size = new System.Drawing.Size(212, 25);
            this.RobotZaxisStatus.TabIndex = 423;
            this.RobotZaxisStatus.TabStop = false;
            this.RobotZaxisStatus.Tag = "50";
            this.RobotZaxisStatus.Text = "--";
            this.RobotZaxisStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 422;
            this.label9.Text = "Z-axis";
            // 
            // RobotArmStatus
            // 
            this.RobotArmStatus.BackColor = System.Drawing.Color.Ivory;
            this.RobotArmStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotArmStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotArmStatus.Location = new System.Drawing.Point(64, 91);
            this.RobotArmStatus.Name = "RobotArmStatus";
            this.RobotArmStatus.ReadOnly = true;
            this.RobotArmStatus.Size = new System.Drawing.Size(212, 25);
            this.RobotArmStatus.TabIndex = 421;
            this.RobotArmStatus.TabStop = false;
            this.RobotArmStatus.Tag = "50";
            this.RobotArmStatus.Text = "--";
            this.RobotArmStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 420;
            this.label8.Text = "Arm";
            // 
            // RobotBusyStatus
            // 
            this.RobotBusyStatus.BackColor = System.Drawing.Color.Ivory;
            this.RobotBusyStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotBusyStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotBusyStatus.Location = new System.Drawing.Point(64, 60);
            this.RobotBusyStatus.Name = "RobotBusyStatus";
            this.RobotBusyStatus.ReadOnly = true;
            this.RobotBusyStatus.Size = new System.Drawing.Size(212, 25);
            this.RobotBusyStatus.TabIndex = 419;
            this.RobotBusyStatus.TabStop = false;
            this.RobotBusyStatus.Tag = "50";
            this.RobotBusyStatus.Text = "--";
            this.RobotBusyStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 418;
            this.label7.Text = "Busy";
            // 
            // RobotInitStatus
            // 
            this.RobotInitStatus.BackColor = System.Drawing.Color.Ivory;
            this.RobotInitStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.RobotInitStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobotInitStatus.Location = new System.Drawing.Point(64, 29);
            this.RobotInitStatus.Name = "RobotInitStatus";
            this.RobotInitStatus.ReadOnly = true;
            this.RobotInitStatus.Size = new System.Drawing.Size(212, 25);
            this.RobotInitStatus.TabIndex = 417;
            this.RobotInitStatus.TabStop = false;
            this.RobotInitStatus.Tag = "50";
            this.RobotInitStatus.Text = "--";
            this.RobotInitStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 416;
            this.label6.Text = "Init";
            // 
            // ModuleSlotNo
            // 
            this.ModuleSlotNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModuleSlotNo.FormattingEnabled = true;
            this.ModuleSlotNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.ModuleSlotNo.Location = new System.Drawing.Point(68, 400);
            this.ModuleSlotNo.Name = "ModuleSlotNo";
            this.ModuleSlotNo.Size = new System.Drawing.Size(121, 28);
            this.ModuleSlotNo.TabIndex = 285;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 284;
            this.label5.Text = "Slot no";
            // 
            // ModuleStage
            // 
            this.ModuleStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModuleStage.FormattingEnabled = true;
            this.ModuleStage.Items.AddRange(new object[] {
            "LoadPort",
            "Aligner",
            "PM"});
            this.ModuleStage.Location = new System.Drawing.Point(68, 366);
            this.ModuleStage.Name = "ModuleStage";
            this.ModuleStage.Size = new System.Drawing.Size(121, 28);
            this.ModuleStage.TabIndex = 283;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 282;
            this.label4.Text = "Module";
            // 
            // btnRobotHome
            // 
            this.btnRobotHome.BackColor = System.Drawing.Color.White;
            this.btnRobotHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotHome.FlatAppearance.BorderSize = 0;
            this.btnRobotHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotHome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotHome.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotHome.Location = new System.Drawing.Point(98, 595);
            this.btnRobotHome.Name = "btnRobotHome";
            this.btnRobotHome.Size = new System.Drawing.Size(86, 32);
            this.btnRobotHome.TabIndex = 281;
            this.btnRobotHome.Tag = "";
            this.btnRobotHome.Text = "Home";
            this.btnRobotHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotHome.UseVisualStyleBackColor = false;
            this.btnRobotHome.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotReset
            // 
            this.btnRobotReset.BackColor = System.Drawing.Color.White;
            this.btnRobotReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotReset.FlatAppearance.BorderSize = 0;
            this.btnRobotReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotReset.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotReset.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotReset.Location = new System.Drawing.Point(190, 595);
            this.btnRobotReset.Name = "btnRobotReset";
            this.btnRobotReset.Size = new System.Drawing.Size(86, 32);
            this.btnRobotReset.TabIndex = 280;
            this.btnRobotReset.Tag = "";
            this.btnRobotReset.Text = "Reset";
            this.btnRobotReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotReset.UseVisualStyleBackColor = false;
            this.btnRobotReset.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotMapping
            // 
            this.btnRobotMapping.BackColor = System.Drawing.Color.White;
            this.btnRobotMapping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotMapping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotMapping.FlatAppearance.BorderSize = 0;
            this.btnRobotMapping.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotMapping.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotMapping.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotMapping.Location = new System.Drawing.Point(190, 633);
            this.btnRobotMapping.Name = "btnRobotMapping";
            this.btnRobotMapping.Size = new System.Drawing.Size(86, 32);
            this.btnRobotMapping.TabIndex = 279;
            this.btnRobotMapping.Tag = "";
            this.btnRobotMapping.Text = "Mapping";
            this.btnRobotMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotMapping.UseVisualStyleBackColor = false;
            this.btnRobotMapping.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotMapSnsPower
            // 
            this.btnRobotMapSnsPower.BackColor = System.Drawing.Color.White;
            this.btnRobotMapSnsPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotMapSnsPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotMapSnsPower.FlatAppearance.BorderSize = 0;
            this.btnRobotMapSnsPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotMapSnsPower.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotMapSnsPower.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotMapSnsPower.Location = new System.Drawing.Point(6, 633);
            this.btnRobotMapSnsPower.Name = "btnRobotMapSnsPower";
            this.btnRobotMapSnsPower.Size = new System.Drawing.Size(178, 32);
            this.btnRobotMapSnsPower.TabIndex = 278;
            this.btnRobotMapSnsPower.Tag = "0";
            this.btnRobotMapSnsPower.Text = "Mapping sensor power";
            this.btnRobotMapSnsPower.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotMapSnsPower.UseVisualStyleBackColor = false;
            this.btnRobotMapSnsPower.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotStop
            // 
            this.btnRobotStop.BackColor = System.Drawing.Color.White;
            this.btnRobotStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotStop.FlatAppearance.BorderSize = 0;
            this.btnRobotStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotStop.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotStop.ForeColor = System.Drawing.Color.Red;
            this.btnRobotStop.Location = new System.Drawing.Point(98, 557);
            this.btnRobotStop.Name = "btnRobotStop";
            this.btnRobotStop.Size = new System.Drawing.Size(86, 32);
            this.btnRobotStop.TabIndex = 277;
            this.btnRobotStop.Tag = "";
            this.btnRobotStop.Text = "Stop";
            this.btnRobotStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotStop.UseVisualStyleBackColor = false;
            this.btnRobotStop.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotResume
            // 
            this.btnRobotResume.BackColor = System.Drawing.Color.White;
            this.btnRobotResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotResume.FlatAppearance.BorderSize = 0;
            this.btnRobotResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotResume.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotResume.ForeColor = System.Drawing.Color.Green;
            this.btnRobotResume.Location = new System.Drawing.Point(6, 595);
            this.btnRobotResume.Name = "btnRobotResume";
            this.btnRobotResume.Size = new System.Drawing.Size(86, 32);
            this.btnRobotResume.TabIndex = 276;
            this.btnRobotResume.Tag = "";
            this.btnRobotResume.Text = "Resume";
            this.btnRobotResume.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotResume.UseVisualStyleBackColor = false;
            this.btnRobotResume.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotPause
            // 
            this.btnRobotPause.BackColor = System.Drawing.Color.White;
            this.btnRobotPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotPause.FlatAppearance.BorderSize = 0;
            this.btnRobotPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotPause.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotPause.ForeColor = System.Drawing.Color.Tomato;
            this.btnRobotPause.Location = new System.Drawing.Point(190, 557);
            this.btnRobotPause.Name = "btnRobotPause";
            this.btnRobotPause.Size = new System.Drawing.Size(86, 32);
            this.btnRobotPause.TabIndex = 275;
            this.btnRobotPause.Tag = "";
            this.btnRobotPause.Text = "Pause";
            this.btnRobotPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotPause.UseVisualStyleBackColor = false;
            this.btnRobotPause.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotEMGStop
            // 
            this.btnRobotEMGStop.BackColor = System.Drawing.Color.White;
            this.btnRobotEMGStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotEMGStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotEMGStop.FlatAppearance.BorderSize = 0;
            this.btnRobotEMGStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotEMGStop.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotEMGStop.ForeColor = System.Drawing.Color.Red;
            this.btnRobotEMGStop.Location = new System.Drawing.Point(6, 557);
            this.btnRobotEMGStop.Name = "btnRobotEMGStop";
            this.btnRobotEMGStop.Size = new System.Drawing.Size(86, 32);
            this.btnRobotEMGStop.TabIndex = 274;
            this.btnRobotEMGStop.Tag = "";
            this.btnRobotEMGStop.Text = "EMG";
            this.btnRobotEMGStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotEMGStop.UseVisualStyleBackColor = false;
            this.btnRobotEMGStop.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotVacuum
            // 
            this.btnRobotVacuum.BackColor = System.Drawing.Color.White;
            this.btnRobotVacuum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotVacuum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotVacuum.FlatAppearance.BorderSize = 0;
            this.btnRobotVacuum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotVacuum.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotVacuum.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotVacuum.Location = new System.Drawing.Point(190, 481);
            this.btnRobotVacuum.Name = "btnRobotVacuum";
            this.btnRobotVacuum.Size = new System.Drawing.Size(86, 32);
            this.btnRobotVacuum.TabIndex = 273;
            this.btnRobotVacuum.Tag = "0";
            this.btnRobotVacuum.Text = "Vacuum";
            this.btnRobotVacuum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotVacuum.UseVisualStyleBackColor = false;
            this.btnRobotVacuum.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotDown
            // 
            this.btnRobotDown.BackColor = System.Drawing.Color.White;
            this.btnRobotDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotDown.FlatAppearance.BorderSize = 0;
            this.btnRobotDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotDown.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotDown.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotDown.Location = new System.Drawing.Point(98, 481);
            this.btnRobotDown.Name = "btnRobotDown";
            this.btnRobotDown.Size = new System.Drawing.Size(86, 32);
            this.btnRobotDown.TabIndex = 272;
            this.btnRobotDown.Tag = "";
            this.btnRobotDown.Text = "Z-Down";
            this.btnRobotDown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotDown.UseVisualStyleBackColor = false;
            this.btnRobotDown.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotUp
            // 
            this.btnRobotUp.BackColor = System.Drawing.Color.White;
            this.btnRobotUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotUp.FlatAppearance.BorderSize = 0;
            this.btnRobotUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotUp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotUp.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotUp.Location = new System.Drawing.Point(6, 481);
            this.btnRobotUp.Name = "btnRobotUp";
            this.btnRobotUp.Size = new System.Drawing.Size(86, 32);
            this.btnRobotUp.TabIndex = 271;
            this.btnRobotUp.Tag = "";
            this.btnRobotUp.Text = "Z-Up";
            this.btnRobotUp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotUp.UseVisualStyleBackColor = false;
            this.btnRobotUp.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotRotation
            // 
            this.btnRobotRotation.BackColor = System.Drawing.Color.White;
            this.btnRobotRotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotRotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotRotation.FlatAppearance.BorderSize = 0;
            this.btnRobotRotation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotRotation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotRotation.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotRotation.Location = new System.Drawing.Point(6, 443);
            this.btnRobotRotation.Name = "btnRobotRotation";
            this.btnRobotRotation.Size = new System.Drawing.Size(86, 32);
            this.btnRobotRotation.TabIndex = 270;
            this.btnRobotRotation.Tag = "";
            this.btnRobotRotation.Text = "Rotation";
            this.btnRobotRotation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotRotation.UseVisualStyleBackColor = false;
            this.btnRobotRotation.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotExtend
            // 
            this.btnRobotExtend.BackColor = System.Drawing.Color.White;
            this.btnRobotExtend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotExtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotExtend.FlatAppearance.BorderSize = 0;
            this.btnRobotExtend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotExtend.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotExtend.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotExtend.Location = new System.Drawing.Point(190, 443);
            this.btnRobotExtend.Name = "btnRobotExtend";
            this.btnRobotExtend.Size = new System.Drawing.Size(86, 32);
            this.btnRobotExtend.TabIndex = 27;
            this.btnRobotExtend.Tag = "";
            this.btnRobotExtend.Text = "Extend";
            this.btnRobotExtend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotExtend.UseVisualStyleBackColor = false;
            this.btnRobotExtend.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // btnRobotRetract
            // 
            this.btnRobotRetract.BackColor = System.Drawing.Color.White;
            this.btnRobotRetract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRobotRetract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobotRetract.FlatAppearance.BorderSize = 0;
            this.btnRobotRetract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRobotRetract.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotRetract.ForeColor = System.Drawing.Color.Navy;
            this.btnRobotRetract.Location = new System.Drawing.Point(98, 443);
            this.btnRobotRetract.Name = "btnRobotRetract";
            this.btnRobotRetract.Size = new System.Drawing.Size(86, 32);
            this.btnRobotRetract.TabIndex = 23;
            this.btnRobotRetract.Tag = "";
            this.btnRobotRetract.Text = "Retract";
            this.btnRobotRetract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobotRetract.UseVisualStyleBackColor = false;
            this.btnRobotRetract.Click += new System.EventHandler(this.Robot_Control_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(755, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 42);
            this.button1.TabIndex = 440;
            this.button1.Tag = "";
            this.button1.Text = "Dry run";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(755, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 42);
            this.button2.TabIndex = 441;
            this.button2.Tag = "";
            this.button2.Text = "Abort";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableUpSns);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PM1BrushFwdSns);
            this.Controls.Add(this.PM1BrushBwdSns);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label_Alarm);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.listBoxEventLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Robot);
            this.Name = "TMForm";
            this.Size = new System.Drawing.Size(1172, 824);
            this.Load += new System.EventHandler(this.TMForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlace;
        public System.Windows.Forms.ListBox listBoxEventLog;
        private System.Windows.Forms.Label label_Alarm;
        private System.Windows.Forms.Panel Robot;
        private System.Windows.Forms.Label TableUpSns;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label PM1BrushFwdSns;
        private System.Windows.Forms.Label PM1BrushBwdSns;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox TargetStage;
        private System.Windows.Forms.ComboBox SourceStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6213;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ComboBox SourceSlotNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TargetSlotNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRobotUp;
        private System.Windows.Forms.Button btnRobotRotation;
        private System.Windows.Forms.Button btnRobotExtend;
        private System.Windows.Forms.Button btnRobotRetract;
        private System.Windows.Forms.Button btnRobotDown;
        private System.Windows.Forms.Button btnRobotVacuum;
        private System.Windows.Forms.Button btnRobotPause;
        private System.Windows.Forms.Button btnRobotEMGStop;
        private System.Windows.Forms.Button btnRobotResume;
        private System.Windows.Forms.Button btnRobotStop;
        private System.Windows.Forms.Button btnRobotMapping;
        private System.Windows.Forms.Button btnRobotMapSnsPower;
        private System.Windows.Forms.Button btnRobotReset;
        private System.Windows.Forms.Button btnRobotHome;
        private System.Windows.Forms.ComboBox ModuleSlotNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ModuleStage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RobotStage1;
        private System.Windows.Forms.TextBox RobotStage10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RobotPauseStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RobotZaxisStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RobotArmStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RobotBusyStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RobotInitStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RobotErrorStatus1;
        private System.Windows.Forms.TextBox RobotErrorStatus10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRobotPlace;
        private System.Windows.Forms.Button btnRobotPick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
