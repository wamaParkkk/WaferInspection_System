
namespace WaferInspection_System
{
    partial class OperationForm
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
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.label_LoadPortAlarm = new System.Windows.Forms.Label();
            this.label_RobotAlarm = new System.Windows.Forms.Label();
            this.label_AlignerAlarm = new System.Windows.Forms.Label();
            this.label_PMAlarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 500;
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // label_LoadPortAlarm
            // 
            this.label_LoadPortAlarm.AutoSize = true;
            this.label_LoadPortAlarm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoadPortAlarm.ForeColor = System.Drawing.Color.Red;
            this.label_LoadPortAlarm.Location = new System.Drawing.Point(12, 9);
            this.label_LoadPortAlarm.Name = "label_LoadPortAlarm";
            this.label_LoadPortAlarm.Size = new System.Drawing.Size(18, 17);
            this.label_LoadPortAlarm.TabIndex = 295;
            this.label_LoadPortAlarm.Text = "--";
            // 
            // label_RobotAlarm
            // 
            this.label_RobotAlarm.AutoSize = true;
            this.label_RobotAlarm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RobotAlarm.ForeColor = System.Drawing.Color.Red;
            this.label_RobotAlarm.Location = new System.Drawing.Point(12, 26);
            this.label_RobotAlarm.Name = "label_RobotAlarm";
            this.label_RobotAlarm.Size = new System.Drawing.Size(18, 17);
            this.label_RobotAlarm.TabIndex = 296;
            this.label_RobotAlarm.Text = "--";
            // 
            // label_AlignerAlarm
            // 
            this.label_AlignerAlarm.AutoSize = true;
            this.label_AlignerAlarm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlignerAlarm.ForeColor = System.Drawing.Color.Red;
            this.label_AlignerAlarm.Location = new System.Drawing.Point(12, 43);
            this.label_AlignerAlarm.Name = "label_AlignerAlarm";
            this.label_AlignerAlarm.Size = new System.Drawing.Size(18, 17);
            this.label_AlignerAlarm.TabIndex = 297;
            this.label_AlignerAlarm.Text = "--";
            // 
            // label_PMAlarm
            // 
            this.label_PMAlarm.AutoSize = true;
            this.label_PMAlarm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PMAlarm.ForeColor = System.Drawing.Color.Red;
            this.label_PMAlarm.Location = new System.Drawing.Point(12, 60);
            this.label_PMAlarm.Name = "label_PMAlarm";
            this.label_PMAlarm.Size = new System.Drawing.Size(18, 17);
            this.label_PMAlarm.TabIndex = 298;
            this.label_PMAlarm.Text = "--";
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 824);
            this.Controls.Add(this.label_PMAlarm);
            this.Controls.Add(this.label_AlignerAlarm);
            this.Controls.Add(this.label_RobotAlarm);
            this.Controls.Add(this.label_LoadPortAlarm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationForm";
            this.Text = "OperationForm";
            this.Activated += new System.EventHandler(this.OperationForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperationForm_FormClosing);
            this.Load += new System.EventHandler(this.OperationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Label label_LoadPortAlarm;
        private System.Windows.Forms.Label label_RobotAlarm;
        private System.Windows.Forms.Label label_AlignerAlarm;
        private System.Windows.Forms.Label label_PMAlarm;
    }
}