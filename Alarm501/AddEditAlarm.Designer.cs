namespace Alarm501
{
    partial class AddEditAlarm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UXSetAlarmBtn = new System.Windows.Forms.Button();
            this.UxCancelEditAlarmBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 29, 22, 30, 0, 0);
            // 
            // UXSetAlarmBtn
            // 
            this.UXSetAlarmBtn.Location = new System.Drawing.Point(375, 154);
            this.UXSetAlarmBtn.Name = "UXSetAlarmBtn";
            this.UXSetAlarmBtn.Size = new System.Drawing.Size(114, 58);
            this.UXSetAlarmBtn.TabIndex = 1;
            this.UXSetAlarmBtn.Text = "Set";
            this.UXSetAlarmBtn.UseVisualStyleBackColor = true;
            // 
            // UxCancelEditAlarmBtn
            // 
            this.UxCancelEditAlarmBtn.Location = new System.Drawing.Point(57, 154);
            this.UxCancelEditAlarmBtn.Name = "UxCancelEditAlarmBtn";
            this.UxCancelEditAlarmBtn.Size = new System.Drawing.Size(114, 58);
            this.UxCancelEditAlarmBtn.TabIndex = 2;
            this.UxCancelEditAlarmBtn.Text = "Cancel";
            this.UxCancelEditAlarmBtn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "On";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 242);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UxCancelEditAlarmBtn);
            this.Controls.Add(this.UXSetAlarmBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddEditAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UXSetAlarmBtn;
        private System.Windows.Forms.Button UxCancelEditAlarmBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}