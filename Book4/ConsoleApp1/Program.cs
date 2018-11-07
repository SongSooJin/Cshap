using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

// 간단한 TCP 클라이언트,서버
// TCP Client & Server 만들기 

// Server
namespace ConsoleApp1
{
    class Server
    {
        public static void Main(string[] args)
        {
            NetworkStream stream = null;
            TcpListener tcpListener = null;
            Socket clientsocket = null;
            StreamReader reader = null;

            try
            {
                //IP주소를 나타내는 객체를 생성,TcpListener를 생성시 인자로 사용할려고
                IPAddress ipAd = IPAddress.Parse("192.168.0.214");

                //TcpListener Class를 이용하여 클라이언트의 연결을 받아 들인다. 
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                //Client의 접속이 올때 까지 Block 되는 부분, 대개 이부분을 Thread로
                //만들어 보내 버린다.
                //백그라운드 Thread에 처리를 맡긴다. 
                clientsocket = tcpListener.AcceptSocket();

                //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
                stream = new NetworkStream(clientsocket);
                Encoding encode = Encoding.GetEncoding("utf-8");

                reader = new StreamReader(stream, encode);

                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally {
                clientsocket.Close();
            }
        }
    }
}
