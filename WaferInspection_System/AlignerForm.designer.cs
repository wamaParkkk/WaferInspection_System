
namespace WaferInspection_System
{
    partial class AlignerForm
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
            this.label35 = new System.Windows.Forms.Label();
            this.label_Alarm = new System.Windows.Forms.Label();
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
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Navy;
            this.label35.Location = new System.Drawing.Point(525, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(141, 47);
            this.label35.TabIndex = 272;
            this.label35.Text = "Aligner";
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
            // AlignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Alarm);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.listBoxEventLog);
            this.Name = "AlignerForm";
            this.Size = new System.Drawing.Size(1172, 824);
            this.Load += new System.EventHandler(this.AlignerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxEventLog;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label_Alarm;
    }
}
