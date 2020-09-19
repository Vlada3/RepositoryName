using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        EndPoint endPoint;
        public Form1()
        {
            InitializeComponent();
            
        }
        void SendMessage()
        {
            var client = new TcpClient();
            client.Connect("192.168.88.153", 1024);
            var nstream = client.GetStream();
            StreamReader sr = new StreamReader(nstream, Encoding.Unicode);
            string s = sr.ReadLine();
            textBox1.Text = s;
            nstream.Close();
            client.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
            

        private void CloseButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
