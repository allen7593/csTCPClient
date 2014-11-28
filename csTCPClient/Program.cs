using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

namespace csTCPClient
{
    class Program
    {

        private const int portNum = 8080;
        private const string hostName = "127.0.0.1";
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Try to connect to " + hostName + ":" + portNum.ToString() + "\r\n");
                TcpClient client = new TcpClient(hostName, portNum);

                NetworkStream ns = client.GetStream();

                byte[] bytes = new byte[1024];
                int byteRead = ns.Read(bytes, 0, bytes.Length);
                Console.WriteLine(Encoding.ASCII.GetString(bytes, 0, byteRead));
                client.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }


    }
}
