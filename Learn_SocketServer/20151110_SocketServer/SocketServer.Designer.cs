namespace _20151110_SocketServer
{
    partial class SocketServer
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
            this.btnStartBind = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnShan = new System.Windows.Forms.Button();
            this.cboUserList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnStartBind
            // 
            this.btnStartBind.Location = new System.Drawing.Point(273, 40);
            this.btnStartBind.Name = "btnStartBind";
            this.btnStartBind.Size = new System.Drawing.Size(75, 23);
            this.btnStartBind.TabIndex = 0;
            this.btnStartBind.Text = "开始监听";
            this.btnStartBind.UseVisualStyleBackColor = true;
            this.btnStartBind.Click += new System.EventHandler(this.btnStartBind_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(39, 40);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(154, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "50001";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.Location = new System.Drawing.Point(39, 86);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(536, 160);
            this.txtLog.TabIndex = 1;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(39, 264);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(536, 160);
            this.txtMsg.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(39, 447);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(351, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(408, 445);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(124, 23);
            this.btnSendFile.TabIndex = 0;
            this.btnSendFile.Text = "打开/发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(408, 504);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 0;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnShan
            // 
            this.btnShan.Location = new System.Drawing.Point(500, 504);
            this.btnShan.Name = "btnShan";
            this.btnShan.Size = new System.Drawing.Size(75, 23);
            this.btnShan.TabIndex = 0;
            this.btnShan.Text = "发送震动";
            this.btnShan.UseVisualStyleBackColor = true;
            // 
            // cboUserList
            // 
            this.cboUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserList.FormattingEnabled = true;
            this.cboUserList.Location = new System.Drawing.Point(454, 40);
            this.cboUserList.Name = "cboUserList";
            this.cboUserList.Size = new System.Drawing.Size(121, 21);
            this.cboUserList.TabIndex = 2;
            // 
            // SocketServer
            // 
            this.AcceptButton = this.btnSendMsg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 539);
            this.Controls.Add(this.cboUserList);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnShan);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnStartBind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SocketServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocketServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocketServer_FormClosing);
            this.Load += new System.EventHandler(this.SocketServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartBind;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnShan;
        private System.Windows.Forms.ComboBox cboUserList;
    }
}

