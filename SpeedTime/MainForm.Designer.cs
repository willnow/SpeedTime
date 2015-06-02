namespace SpeedTime
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ckbCurTime = new System.Windows.Forms.CheckBox();
            this.dateTimePickerBeginTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "倍数";
            // 
            // cbSpeed
            // 
            this.cbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Location = new System.Drawing.Point(83, 82);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(225, 20);
            this.cbSpeed.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(126, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "应用";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timerSpeed
            // 
            this.timerSpeed.Enabled = true;
            this.timerSpeed.Interval = 10;
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "初始时间";
            // 
            // ckbCurTime
            // 
            this.ckbCurTime.AutoSize = true;
            this.ckbCurTime.Checked = true;
            this.ckbCurTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCurTime.Location = new System.Drawing.Point(83, 38);
            this.ckbCurTime.Name = "ckbCurTime";
            this.ckbCurTime.Size = new System.Drawing.Size(72, 16);
            this.ckbCurTime.TabIndex = 4;
            this.ckbCurTime.Text = "当前时间";
            this.ckbCurTime.UseVisualStyleBackColor = true;
            this.ckbCurTime.CheckedChanged += new System.EventHandler(this.ckbCurTime_CheckedChanged);
            // 
            // dateTimePickerBeginTime
            // 
            this.dateTimePickerBeginTime.Enabled = false;
            this.dateTimePickerBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBeginTime.Location = new System.Drawing.Point(161, 33);
            this.dateTimePickerBeginTime.Name = "dateTimePickerBeginTime";
            this.dateTimePickerBeginTime.Size = new System.Drawing.Size(147, 21);
            this.dateTimePickerBeginTime.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 174);
            this.Controls.Add(this.dateTimePickerBeginTime);
            this.Controls.Add(this.ckbCurTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间加速";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbCurTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTime;
    }
}

