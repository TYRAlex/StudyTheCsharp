using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketServerTest
{
    internal class Program
    {
        private static Socket serverSocket;
        public static void Main(string[] args)
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6666));
            serverSocket.Listen(10);
            Console.WriteLine("服务器启动成功");
            Thread thread=new Thread(AcceptClient);
            thread.Start();
            Console.ReadKey();
        }

        private static void AcceptClient()
        {
            Socket clientSocket = serverSocket.Accept();
            byte[] data = Encoding.Default.GetBytes("服务器告诉你连接成功了");
            clientSocket.Send(data);
            Thread thread=new Thread(ReveiveMsg);
            thread.Start(clientSocket);
        }

        private static void ReveiveMsg(object clientSocket)
        {
            byte[] data = new byte[1024];
            int length = (clientSocket as Socket).Receive(data);
            Console.WriteLine(Encoding.Default.GetString(data, 0, length));
        }
    }
}