using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastClient
{
    public partial class Form1 : Form
    {
        delegate void AppendText(string text); 
        void AppendTextProc(string text) 
        { 
            richTextBoxClient.Text = text; 
        }
        void Listner()
        {
            while (true)
            {
                Socket soc = new Socket(AddressFamily.InterNetwork, 
                                        SocketType.Dgram, 
                                        ProtocolType.Udp); 
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 4567); 
                soc.Bind(ipep); 
                IPAddress ip = IPAddress.Parse("224.5.5.5");
                soc.SetSocketOption(SocketOptionLevel.IP,
                                    SocketOptionName.AddMembership,
                                    new MulticastOption(ip, IPAddress.Any));
                byte[] buff = new byte[1024];
                soc.Receive(buff);
                Thread.Sleep(1000);
                this.Invoke(new AppendText(AppendTextProc), Encoding.Default.GetString(buff));
                soc.Close();
            } 
        }
        Thread listen;
        public Form1()
        {
            InitializeComponent();
            listen = new Thread(new ThreadStart(Listner)); 
            listen.IsBackground = true; 
            listen.Start();
        }
    }
}
