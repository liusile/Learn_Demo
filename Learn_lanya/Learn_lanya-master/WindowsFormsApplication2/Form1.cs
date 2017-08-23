using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        BluetoothClient client;
        BluetoothListener bluetoothListener;
        Thread listenThread;
        bool isConnected;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listenThread = new Thread(ReceiveData);
            listenThread.Start();
        }
        private void ReceiveData()
        {
            try
            {
               // Guid guid = new Guid("db764ac8-4b08-7f25-aafe-59d03c27bae3");
                
                BluetoothListener listener = new BluetoothListener(BluetoothService.SerialPort);//00001101-0000-1000-8000-00805F9B34FB
                listener.Start();
                Console.WriteLine("Service started!");
                while (true)
                {
                     client = listener.AcceptBluetoothClient();
                     Console.WriteLine("Got a request!");

                    Stream peerStream = client.GetStream();

                    byte[] buffer = new byte[500];
                    while (true)
                    {
                        if (peerStream.CanRead)
                        {
                            peerStream.Read(buffer, 0, 500);
                            //string data = System.Text.ASCIIEncoding.ASCII.GetString(buffer, 0, 50);
                             string data1 = System.Text.ASCIIEncoding.UTF8.GetString(buffer, 0, 500);
                            //string data2 = Encoding.GetEncoding("gb2312").GetString(buffer);
                            Console.WriteLine("Receiving data: " + data1);
                        }
                    }
                   
                 

                    //byte[] buffer = new byte[2000];

                    //peerStream.Read(buffer, 0, 1);
                    ////while (true)
                    ////{
                    ////    if (peerStream.CanRead)
                    ////    {
                    ////        r = peerStream.Read(buffer, r, 1);
                    ////    }
                    ////    else
                    ////    {
                    ////        break;
                    ////    }
                    ////}
                    //string data = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    //Console.WriteLine("Receiving data: " + data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex.Message);
            }
        }






























        //client = new BluetoothClient();
        //BluetoothDeviceInfo[] devices = client.DiscoverDevices();
        //BluetoothDeviceInfo device = null;
        //foreach (BluetoothDeviceInfo d in devices)
        //{
        //    if (d.DeviceName == "PDT-900")//PDT-900
        //    {
        //        device = d;
        //        break;
        //    }
        //}
        //if (device != null)
        //{
        //    Console.Write(String.Format("Name:{0} Address:{1:C}", device.DeviceName, device.DeviceAddress));
        //    client.Connect(device.DeviceAddress, BluetoothService.Handsfree);

        //    Console.WriteLine("collect is "+client.Connected);


        //    return;

        //    //Stream peerStream = client.GetStream();
        //    //byte[] dataBuffer = System.Text.ASCIIEncoding.ASCII.GetBytes("iiiii");
        //    //peerStream.Write(dataBuffer, 0, dataBuffer.Length);
        //    //peerStream.Close();

        //    //Stream peerStream = client.GetStream();

        //    //// Create storage for receiving data
        //    //byte[] buffer = new byte[2000];

        //    //while (true)
        //    //{
        //    //    // Read Data
        //    //    peerStream.Read(buffer, 0, 50);

        //    //    // Convert Data to String
        //    //    string data = System.Text.ASCIIEncoding.ASCII.GetString(buffer, 0, 50);
        //    //    Console.Write("Receiving data: " + data);
        //    //}
        //  //  Console.Write("Receiving data: " + data);

        //    //int i = 0;
        //    //while (true)
        //    //{
        //    //    Console.Write("Writing: " + i.ToString());
        //    //    byte[] dataBuffer = System.Text.ASCIIEncoding.ASCII.GetBytes(i.ToString());

        //    //    peerStream.Write(dataBuffer, 0, dataBuffer.Length);
        //    //    ++i;
        //    //    if (i >= int.MaxValue)
        //    //    {
        //    //        i = 0;
        //    //    }
        //    //    System.Threading.Thread.Sleep(500);
        //    //}
        //    //// Close network stream
        //    //peerStream.Close();
        //    //while (true)
        //    //{
        //    //    byte[] dataBuffer = new byte[100];
        //    //    Stream peerStream = peerStream.GetStream();

        //    //    peerStream.Read(buffer, 0, buffer.Length);

        //    //    string data = Encoding.UTF8.GetString(buffer).ToString().Replace("\0", "");//去掉后面的\0字节
        //    //}
        //}
    
        private void WriteByText(string msg)
        {
            Invoke((MethodInvoker)delegate()
            {
                textBox1.Text = msg;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[2000];
            Stream peerStream = client.GetStream();
            peerStream.Read(buffer, 0, 50);
            string data = System.Text.ASCIIEncoding.ASCII.GetString(buffer, 0, 50);
            Console.Write("Receiving data: " + data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dataToSend = "Hello from service!";

            // Convert dataToSend into a byte array
            byte[] dataBuffer = System.Text.ASCIIEncoding.ASCII.GetBytes(dataToSend);
            client.GetStream().Write(dataBuffer, 0, dataBuffer.Length);
            // Output data to stream
            // peerStream.Write();
        }
    }
}
