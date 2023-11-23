
namespace WaferInspection_System
{
    partial class ConfigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTableUpDnTimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNozzleFwdBwdTimeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParameterSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.txtBoxBrushFwdBwdTimeout = new System.Windows.Forms.TextBox();
            this.txtBoxDoorOpenCloseTimeout = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxMoveTimeout = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxWaterblockMoveSpeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBrushDownPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxBrushUpPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMotionParameterSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxBrushUpDnSpeed = new System.Windows.Forms.TextBox();
            this.txtBoxBrushRotationSpeed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTableUpDnTimeout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxNozzleFwdBwdTimeout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnParameterSave);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtBoxBrushFwdBwdTimeout);
            this.groupBox1.Controls.Add(this.txtBoxDoorOpenCloseTimeout);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(248, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(689, 289);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< System Time out >";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(495, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Sec";
            // 
            // txtBoxTableUpDnTimeout
            // 
            this.txtBoxTableUpDnTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxTableUpDnTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxTableUpDnTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTableUpDnTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxTableUpDnTimeout.Location = new System.Drawing.Point(333, 176);
            this.txtBoxTableUpDnTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxTableUpDnTimeout.Name = "txtBoxTableUpDnTimeout";
            this.txtBoxTableUpDnTimeout.ReadOnly = true;
            this.txtBoxTableUpDnTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxTableUpDnTimeout.TabIndex = 46;
            this.txtBoxTableUpDnTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTableUpDnTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(26, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Table up/down time out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(495, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sec";
            // 
            // txtBoxNozzleFwdBwdTimeout
            // 
            this.txtBoxNozzleFwdBwdTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxNozzleFwdBwdTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxNozzleFwdBwdTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNozzleFwdBwdTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxNozzleFwdBwdTimeout.Location = new System.Drawing.Point(333, 134);
            this.txtBoxNozzleFwdBwdTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxNozzleFwdBwdTimeout.Name = "txtBoxNozzleFwdBwdTimeout";
            this.txtBoxNozzleFwdBwdTimeout.ReadOnly = true;
            this.txtBoxNozzleFwdBwdTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxNozzleFwdBwdTimeout.TabIndex = 43;
            this.txtBoxNozzleFwdBwdTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxNozzleFwdBwdTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nozzle fwd/bwd time out";
            // 
            // btnParameterSave
            // 
            this.btnParameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParameterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParameterSave.FlatAppearance.BorderSize = 0;
            this.btnParameterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParameterSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameterSave.ForeColor = System.Drawing.Color.Navy;
            this.btnParameterSave.ImageIndex = 0;
            this.btnParameterSave.ImageList = this.imageList1;
            this.btnParameterSave.Location = new System.Drawing.Point(553, 226);
            this.btnParameterSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnParameterSave.Name = "btnParameterSave";
            this.btnParameterSave.Size = new System.Drawing.Size(126, 51);
            this.btnParameterSave.TabIndex = 41;
            this.btnParameterSave.Text = "Save";
            this.btnParameterSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParameterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParameterSave.UseVisualStyleBackColor = true;
            this.btnParameterSave.Click += new System.EventHandler(this.btnParameterSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Save.png");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(495, 101);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 21);
            this.label24.TabIndex = 33;
            this.label24.Text = "Sec";
            // 
            // txtBoxBrushFwdBwdTimeout
            // 
            this.txtBoxBrushFwdBwdTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushFwdBwdTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushFwdBwdTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushFwdBwdTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushFwdBwdTimeout.Location = new System.Drawing.Point(333, 92);
            this.txtBoxBrushFwdBwdTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushFwdBwdTimeout.Name = "txtBoxBrushFwdBwdTimeout";
            this.txtBoxBrushFwdBwdTimeout.ReadOnly = true;
            this.txtBoxBrushFwdBwdTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushFwdBwdTimeout.TabIndex = 31;
            this.txtBoxBrushFwdBwdTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushFwdBwdTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // txtBoxDoorOpenCloseTimeout
            // 
            this.txtBoxDoorOpenCloseTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxDoorOpenCloseTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxDoorOpenCloseTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDoorOpenCloseTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxDoorOpenCloseTimeout.Location = new System.Drawing.Point(333, 50);
            this.txtBoxDoorOpenCloseTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxDoorOpenCloseTimeout.Name = "txtBoxDoorOpenCloseTimeout";
            this.txtBoxDoorOpenCloseTimeout.ReadOnly = true;
            this.txtBoxDoorOpenCloseTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxDoorOpenCloseTimeout.TabIndex = 30;
            this.txtBoxDoorOpenCloseTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxDoorOpenCloseTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Navy;
            this.label27.Location = new System.Drawing.Point(26, 50);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(296, 25);
            this.label27.TabIndex = 22;
            this.label27.Text = "Cover door open/close time out";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Navy;
            this.label26.Location = new System.Drawing.Point(495, 59);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 21);
            this.label26.TabIndex = 24;
            this.label26.Text = "Sec";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Navy;
            this.label25.Location = new System.Drawing.Point(26, 92);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(229, 25);
            this.label25.TabIndex = 25;
            this.label25.Text = "Brush fwd/bwd time out";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxMoveTimeout);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtBoxWaterblockMoveSpeed);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxBrushDownPosition);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxBrushUpPosition);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnMotionParameterSave);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxBrushUpDnSpeed);
            this.groupBox2.Controls.Add(this.txtBoxBrushRotationSpeed);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(248, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(689, 389);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "< Motion parameter (Process)>";
            // 
            // txtBoxMoveTimeout
            // 
            this.txtBoxMoveTimeout.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxMoveTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxMoveTimeout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMoveTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxMoveTimeout.Location = new System.Drawing.Point(333, 260);
            this.txtBoxMoveTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxMoveTimeout.Name = "txtBoxMoveTimeout";
            this.txtBoxMoveTimeout.ReadOnly = true;
            this.txtBoxMoveTimeout.Size = new System.Drawing.Size(152, 30);
            this.txtBoxMoveTimeout.TabIndex = 53;
            this.txtBoxMoveTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxMoveTimeout.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(26, 260);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "[All] Move time out";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(495, 269);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 21);
            this.label16.TabIndex = 52;
            this.label16.Text = "Sec";
            // 
            // txtBoxWaterblockMoveSpeed
            // 
            this.txtBoxWaterblockMoveSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxWaterblockMoveSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxWaterblockMoveSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWaterblockMoveSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxWaterblockMoveSpeed.Location = new System.Drawing.Point(333, 218);
            this.txtBoxWaterblockMoveSpeed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxWaterblockMoveSpeed.Name = "txtBoxWaterblockMoveSpeed";
            this.txtBoxWaterblockMoveSpeed.ReadOnly = true;
            this.txtBoxWaterblockMoveSpeed.Size = new System.Drawing.Size(152, 30);
            this.txtBoxWaterblockMoveSpeed.TabIndex = 50;
            this.txtBoxWaterblockMoveSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxWaterblockMoveSpeed.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(26, 218);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(245, 25);
            this.label13.TabIndex = 48;
            this.label13.Text = "[Water block] Move speed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(495, 227);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 49;
            this.label14.Text = "Unit/Sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(495, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Unit";
            // 
            // txtBoxBrushDownPosition
            // 
            this.txtBoxBrushDownPosition.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushDownPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushDownPosition.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushDownPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushDownPosition.Location = new System.Drawing.Point(333, 176);
            this.txtBoxBrushDownPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushDownPosition.Name = "txtBoxBrushDownPosition";
            this.txtBoxBrushDownPosition.ReadOnly = true;
            this.txtBoxBrushDownPosition.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushDownPosition.TabIndex = 46;
            this.txtBoxBrushDownPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushDownPosition.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(26, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "[Brush] Down position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(495, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Unit";
            // 
            // txtBoxBrushUpPosition
            // 
            this.txtBoxBrushUpPosition.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushUpPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushUpPosition.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushUpPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushUpPosition.Location = new System.Drawing.Point(333, 134);
            this.txtBoxBrushUpPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushUpPosition.Name = "txtBoxBrushUpPosition";
            this.txtBoxBrushUpPosition.ReadOnly = true;
            this.txtBoxBrushUpPosition.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushUpPosition.TabIndex = 43;
            this.txtBoxBrushUpPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushUpPosition.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(26, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "[Brush] Up position";
            // 
            // btnMotionParameterSave
            // 
            this.btnMotionParameterSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMotionParameterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotionParameterSave.FlatAppearance.BorderSize = 0;
            this.btnMotionParameterSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMotionParameterSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotionParameterSave.ForeColor = System.Drawing.Color.Navy;
            this.btnMotionParameterSave.ImageIndex = 0;
            this.btnMotionParameterSave.ImageList = this.imageList1;
            this.btnMotionParameterSave.Location = new System.Drawing.Point(553, 326);
            this.btnMotionParameterSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMotionParameterSave.Name = "btnMotionParameterSave";
            this.btnMotionParameterSave.Size = new System.Drawing.Size(126, 51);
            this.btnMotionParameterSave.TabIndex = 41;
            this.btnMotionParameterSave.Text = "Save";
            this.btnMotionParameterSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMotionParameterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMotionParameterSave.UseVisualStyleBackColor = true;
            this.btnMotionParameterSave.Click += new System.EventHandler(this.btnMotionParameterSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(495, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Unit/Sec";
            // 
            // txtBoxBrushUpDnSpeed
            // 
            this.txtBoxBrushUpDnSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushUpDnSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushUpDnSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushUpDnSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushUpDnSpeed.Location = new System.Drawing.Point(333, 50);
            this.txtBoxBrushUpDnSpeed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushUpDnSpeed.Name = "txtBoxBrushUpDnSpeed";
            this.txtBoxBrushUpDnSpeed.ReadOnly = true;
            this.txtBoxBrushUpDnSpeed.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushUpDnSpeed.TabIndex = 31;
            this.txtBoxBrushUpDnSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushUpDnSpeed.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // txtBoxBrushRotationSpeed
            // 
            this.txtBoxBrushRotationSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBrushRotationSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBrushRotationSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBrushRotationSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxBrushRotationSpeed.Location = new System.Drawing.Point(333, 92);
            this.txtBoxBrushRotationSpeed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBoxBrushRotationSpeed.Name = "txtBoxBrushRotationSpeed";
            this.txtBoxBrushRotationSpeed.ReadOnly = true;
            this.txtBoxBrushRotationSpeed.Size = new System.Drawing.Size(152, 30);
            this.txtBoxBrushRotationSpeed.TabIndex = 30;
            this.txtBoxBrushRotationSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxBrushRotationSpeed.Click += new System.EventHandler(this.txtBoxDoorOpenCloseTimeout_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(26, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "[Brush] Rotation speed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(495, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Unit/Sec";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(26, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "[Brush] Up/Down speed";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 824);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ConfigureForm";
            this.Text = "Configure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigureForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParameterSave;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBoxBrushFwdBwdTimeout;
        private System.Windows.Forms.TextBox txtBoxDoorOpenCloseTimeout;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTableUpDnTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNozzleFwdBwdTimeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxBrushDownPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxBrushUpPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMotionParameterSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxBrushUpDnSpeed;
        private System.Windows.Forms.TextBox txtBoxBrushRotationSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxWaterblockMoveSpeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxMoveTimeout;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}