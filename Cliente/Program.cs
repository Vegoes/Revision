using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Cliente()
        {
            byte[] tam = new byte[1000];
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 31416);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // El cliente inicia la conexión haciendo petición con Connect
                server.Connect(ie);
                string directory = Environment.GetEnvironmentVariable("homepath");
                FileStream fs;
                fs = new FileStream(directory + "\\CosoProba.txt", FileMode.Create);
                fs.WriteByte(Convert.ToByte(server.Receive(tam, 0, 1000, 0)));
                fs.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("Erros de conexión: {0}\nCódigo de conexión: {1}({2})",
                e.Message, (SocketError)e.ErrorCode, e.ErrorCode);
                Console.ReadKey();
                return;
            }
        }
        static void Main(string[] args)
        {
            Cliente();
        }
    }
}
