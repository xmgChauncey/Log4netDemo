namespace Log4netDemo
{
    partial class Log4netDemoForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_LogInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_LogInfo
            // 
            this.button_LogInfo.Location = new System.Drawing.Point(161, 89);
            this.button_LogInfo.Name = "button_LogInfo";
            this.button_LogInfo.Size = new System.Drawing.Size(75, 23);
            this.button_LogInfo.TabIndex = 0;
            this.button_LogInfo.Text = "记录日志";
            this.button_LogInfo.UseVisualStyleBackColor = true;
            this.button_LogInfo.Click += new System.EventHandler(this.button_LogInfo_Click);
            // 
            // Log4netDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 232);
            this.Controls.Add(this.button_LogInfo);
            this.Name = "Log4netDemoForm";
            this.Text = "Log4netDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_LogInfo;
    }
}

