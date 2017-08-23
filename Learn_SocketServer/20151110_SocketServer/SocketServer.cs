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

namespace _20151110_SocketServer
{
    public partial class SocketServer : Form
    {
        Socket socketWatch;
        Socket socketSend;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        public SocketServer()
        {
            InitializeComponent();
        }

        #region SocketServer_Load
        private void SocketServer_Load(object sender, EventArgs e)
        {
            //取消跨线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region btnStartBind_Click
        private void btnStartBind_Click(object sender, EventArgs e)
        {
            try
            {
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint point = new IPEndPoint(IPAddress.Parse(txtIP.Text.Trim()), Convert.ToInt32(txtPort.Text.Trim()));
                socketWatch.Bind(point);
                ShowMsgSend("监听成功！！！");
                socketWatch.Listen(10);

                //Thread
                Thread th = new Thread(Accept);
                th.IsBackground = true;
                th.Start(socketWatch);

                //禁用StartBind button
                btnStartBind.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                string selectedIP = cboUserList.SelectedItem.ToString();
                dicSocket[selectedIP].Send(buffer);

                ShowMsgLocal(string.Format("{0}--{1}:\r\n{2}", "LocalHost", DateTime.Now.ToString(), strMsg));
                //清除文本框中的内容
                txtMsg.Clear();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Accept
        private void Accept(object socketObj)
        {
            try
            {
                Socket socketWatch = socketObj as Socket;
                while (true)
                {
                    socketSend = socketWatch.Accept();
                    ShowMsgSend(socketSend.RemoteEndPoint.ToString() + "连接成功");
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    cboUserList.Items.Add(socketSend.RemoteEndPoint.ToString());

                    //设置Combobox的默认值
                    if (cboUserList.Items.Count > 0)
                    {
                        cboUserList.SelectedIndex = 0;
                    }

                    Thread th = new Thread(Receive);
                    th.IsBackground = true;
                    th.Start();
                }
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

        private void SocketServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socketSend.Close();
            }
            catch (Exception)
            {
            }
        }

    }
}
