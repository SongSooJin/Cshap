using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

// 클라이언트 

namespace ConsoleApp7
{
    public class ClientHandler
    {
        public StreamReader readerStream;
        public void runClient() {
            try
            {
                while (true)
                {
                    string returnData;
                    returnData = readerStream.ReadLine();
                    Console.WriteLine("Server:" + returnData);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    class TcpClientTest {
        static void Main(string[] args) {
            TcpClient client = null;
            try
            {
                Encoding encode = Encoding.GetEncoding("utf-8");
                client = new TcpClient();
                client.Connect("192.168.0.214", 5001);
                NetworkStream stream = client.GetStream();
                StreamReader readerStream = new StreamReader(stream, encode);
                string sendstr = null;
                byte[] senddata = new byte[200];
                ClientHandler cHandler = new ClientHandler();
                Thread clientThread = new Thread(new ThreadStart(cHandler.runClient));
                clientThread.Start();
                cHandler.readerStream = readerStream;
                while (true)
                {
                    sendstr = Console.ReadLine();
                    sendstr += "\r\n";
                    senddata = Encoding.Default.GetBytes(sendstr);
                    stream.Write(senddata, 0, senddata.Length);
                    if (sendstr.IndexOf("") > -1) break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                client.Close();
            }
        }
    }
}
