﻿namespace Alarm501
{
    partial class Alarm501
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
            this.UxEditBtn = new System.Windows.Forms.Button();
            this.UxAddBtn = new System.Windows.Forms.Button();
            this.UxAlarmList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxEditBtn
            // 
            this.UxEditBtn.Location = new System.Drawing.Point(37, 26);
            this.UxEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxEditBtn.Name = "UxEditBtn";
            this.UxEditBtn.Size = new System.Drawing.Size(108, 58);
            this.UxEditBtn.TabIndex = 0;
            this.UxEditBtn.Text = "Edit";
            this.UxEditBtn.UseVisualStyleBackColor = true;
            this.UxEditBtn.Click += new System.EventHandler(this.UxEditBtn_Click);
            // 
            // UxAddBtn
            // 
            this.UxAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAddBtn.Location = new System.Drawing.Point(215, 26);
            this.UxAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxAddBtn.Name = "UxAddBtn";
            this.UxAddBtn.Size = new System.Drawing.Size(105, 58);
            this.UxAddBtn.TabIndex = 1;
            this.UxAddBtn.Text = "+";
            this.UxAddBtn.UseVisualStyleBackColor = true;
            this.UxAddBtn.Click += new System.EventHandler(this.UxAddBtn_Click);
            // 
            // UxAlarmList
            // 
            this.UxAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAlarmList.FormattingEnabled = true;
            this.UxAlarmList.ItemHeight = 37;
            this.UxAlarmList.Location = new System.Drawing.Point(37, 134);
            this.UxAlarmList.Margin = new System.Windows.Forms.Padding(2);
            this.UxAlarmList.Name = "UxAlarmList";
            this.UxAlarmList.ScrollAlwaysVisible = true;
            this.UxAlarmList.Size = new System.Drawing.Size(284, 226);
            this.UxAlarmList.TabIndex = 2;
            this.UxAlarmList.SelectedIndexChanged += new System.EventHandler(this.UxAlarmList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Snooze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 458);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alarm went OFF";
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UxAlarmList);
            this.Controls.Add(this.UxAddBtn);
            this.Controls.Add(this.UxEditBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxEditBtn;
        private System.Windows.Forms.Button UxAddBtn;
        private System.Windows.Forms.ListBox UxAlarmList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

