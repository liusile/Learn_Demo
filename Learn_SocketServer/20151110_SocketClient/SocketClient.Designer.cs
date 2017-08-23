namespace _20151110_SocketClient
{
    partial class SocketClient
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnStartConnect = new System.Windows.Forms.Button();
            this.btnShan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(136, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "50001";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(21, 236);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(536, 160);
            this.txtMsg.TabIndex = 8;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLog.Location = new System.Drawing.Point(21, 58);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(536, 160);
            this.txtLog.TabIndex = 9;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(21, 419);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(351, 20);
            this.txtFilePath.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(21, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 11;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Enabled = false;
            this.btnSendFile.Location = new System.Drawing.Point(390, 417);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(124, 23);
            this.btnSendFile.TabIndex = 3;
            this.btnSendFile.Text = "打开/发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(390, 476);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 5;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnStartConnect
            // 
            this.btnStartConnect.Location = new System.Drawing.Point(255, 12);
            this.btnStartConnect.Name = "btnStartConnect";
            this.btnStartConnect.Size = new System.Drawing.Size(75, 23);
            this.btnStartConnect.TabIndex = 6;
            this.btnStartConnect.Text = "开始连接";
            this.btnStartConnect.UseVisualStyleBackColor = true;
            this.btnStartConnect.Click += new System.EventHandler(this.btnStartConnect_Click);
            // 
            // btnShan
            // 
            this.btnShan.Enabled = false;
            this.btnShan.Location = new System.Drawing.Point(482, 476);
            this.btnShan.Name = "btnShan";
            this.btnShan.Size = new System.Drawing.Size(75, 23);
            this.btnShan.TabIndex = 4;
            this.btnShan.Text = "发送震动";
            this.btnShan.UseVisualStyleBackColor = true;
            // 
            // SocketClient
            // 
            this.AcceptButton = this.btnSendMsg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 503);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnShan);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnStartConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SocketClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SocketClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SocketClient_FormClosing);
            this.Load += new System.EventHandler(this.SocketClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnStartConnect;
        private System.Windows.Forms.Button btnShan;
    }
}

