using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _20151110_SocketServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SocketServer());
        }
    }
}
