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
using System.Collections;

// 서버 

namespace ConsoleApp8
{
    public class ClientHandler
    {
        public Socket clientSocket;
        public void runClient() {

        NetworkStream stream = null;
        StreamReader reader = null;

            try
            {
                Encoding encode = Encoding.GetEncoding("utf-8");
                EchoServer.socketList.Add(clientSocket);
                stream = new NetworkStream(clientSocket);
                reader = new StreamReader(stream, encode);

                while (true)
                {
                    string str = reader.ReadLine();
                    if (str.IndexOf("") > -1)
                    {
                        Console.WriteLine("Bye Bye");
                        break;
                    }
                    Console.WriteLine(str);
                    str += "\r\n";

                    foreach (Socket sock in EchoServer.socketList)
                    {
                        NetworkStream streamp = new NetworkStream(sock);
                        byte[] dataWrite = Encoding.Default.GetBytes(str);
                        streamp.Write(dataWrite, 0, dataWrite.Length);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally {
                EchoServer.socketList.Remove(clientSocket);
                clientSocket.Close();
            }
        }
    }
    public class EchoServer {
        static public ArrayList socketList = new ArrayList();
        static void Main(string[] args) {
            TcpListener tcpListener = null;
            try
            {
                IPAddress ipAd = IPAddress.Parse("192.168.0.214");
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();
                Console.WriteLine("[Server]Chatting Server is start..");

                while (true)
                {
                    Socket client = tcpListener.AcceptSocket();
                    ClientHandler cHandler = new ClientHandler();
                    cHandler.clientSocket = client;
                    Thread clientThread = new Thread(new ThreadStart(cHandler.runClient));
                    clientThread.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally {
                tcpListener.Stop();
            }
        }
    }
}
