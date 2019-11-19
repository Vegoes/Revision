using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Servidor
{
    class Program
    {
        static void Servidor()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Bind(ie);
            s.Listen(1);
            Socket sClient = s.Accept();
            string directory = Environment.GetEnvironmentVariable("homepath");
            string fileName = directory + "\\Desktop\\Coso.txt";
            sClient.SendFile(fileName);
            sClient.Close();
            Console.WriteLine("Archivo copiado");
        }

        static void Main(string[] args)
        {
            Servidor();
        }
    }
}
