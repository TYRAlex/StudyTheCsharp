using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketClientTest
{
    internal class Program
    {
        private static Socket clientSocket;
        public static void Main(string[] args)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666));
            Console.WriteLine("与服务器建立了连接");
            clientSocket.Send(Encoding.Default.GetBytes("客户端发送的一条消息"));
            Thread thread=new Thread(Receive);
            thread.Start();
            Console.ReadKey();
        }

        private static void Receive()
        {
            byte[] data = new byte[1024];
            int length = clientSocket.Receive(data);
            Console.WriteLine(Encoding.Default.GetString(data, 0, length));
        }
    }
}