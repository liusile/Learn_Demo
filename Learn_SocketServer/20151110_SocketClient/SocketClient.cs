using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _20151110_SocketClient
{
    public partial class SocketClient : Form
    {

        Socket socketSend;
        public SocketClient()
        {
            InitializeComponent();
        }

        #region SocketClient_Load
        private void SocketClient_Load(object sender, EventArgs e)
        {
            //取消跨线程检查操作
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region btnStartConnect_Click
        private void btnStartConnect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint point = new IPEndPoint(IPAddress.Parse(txtIP.Text.Trim()), Convert.ToInt32(txtPort.Text.Trim()));
                socketSend.Connect(point);
                ShowMsgSend(string.Format("连接{0}服务器成功！",txtIP.Text.Trim()));

                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start();

                //禁用Connect button
                btnStartConnect.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("服务器暂时没有开启，请稍后再试！");
            }
        }
        #endregion

        #region btnSendMsg_Click
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = txtMsg.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(strMsg);
                socketSend.Send(buffer);

                ShowMsgLocal(string.Format("{0}--{1}:\r\n{2}", "LocalHost", DateTime.Now.ToString(), strMsg));

                //清除文本框中的内容
                txtMsg.Clear();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Receive
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string strMsg = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsgSend(string.Format("{0}--{1}:\r\n{2}", socketSend.RemoteEndPoint.ToString(), DateTime.Now.ToString(), strMsg));
                }
            }
            catch (Exception)
            {
            }

        }
        #endregion

        #region ShowMsgSend
        private void ShowMsgSend(string strMsg)
        {
            txtLog.AppendText(strMsg + "\r\n");
        }
        #endregion

        #region ShowMsgLocal
        private void ShowMsgLocal(string strMsg)
        {
            txtLog.AppendText(strMsg + "\r\n");
        } 
        #endregion

        #region SocketClient_FormClosing
        private void SocketClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socketSend.Close();
            }
            catch (Exception)
            {
            }
        } 
        #endregion
    }
}
