using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server1
{
    class Program
    {
        static readonly TcpListener listener = new TcpListener(IPAddress.Parse("192.168.88.153"), Convert.ToInt32("1024"));

       
        static void ThreadFun()
        {
            while (true)
            {
                if (listener.Pending())
                {
                    var client = listener.AcceptTcpClient();
                    //var task = Task.Run(() =>
                    //{
                        var nstream = client.GetStream();
                        byte[] barray = Encoding.Unicode.GetBytes("Some Prediction");
                        nstream.Write(barray, 0, barray.Length);
                        nstream.Close();
                    //});
                    client.Close();
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(ThreadFun);
            thread.IsBackground = true;
            thread.Start();
            listener.Start();
            Console.ReadKey();
        }
    }
}
