using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
// 콘솔기반의 채팅 프로그램

// 서버 

namespace ConsoleApp4
{
    class ClientHadler
    {

        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;

        public ClientHadler(Socket socket)
        {
            this.socket = socket;
            Server.list.Add(socket);
        }

        public void chat()
        {
            //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
            stream = new NetworkStream(socket);
            Encoding encode = Encoding.GetEncoding("utf-8");

            reader = new StreamReader(stream, encode);
            writer = new StreamWriter(stream, encode) { AutoFlush = true };

            while (true)
            {
                string str = reader.ReadLine();
                Console.WriteLine(str);

                // ArrayList에 보관된 모든 클라이언트 처리 소켓만큼
                // 현재 접속한 모든 클라이언트에게 글을 씀
                foreach (Socket s in Server.list) {
                    //클라이언트의 데이터를 읽고, 쓰기 위한 스트림을 만든다. 
                    stream = new NetworkStream(s);
                    writer = new StreamWriter(stream, encode) { AutoFlush = true };

                    writer.WriteLine(str);
                }
            }
        }
    }

    class Server
    {
        public static List<Socket> list = new List<Socket>();
        public static void Main()
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;

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
                while (true)
                {
                    clientsocket = tcpListener.AcceptSocket();

                    ClientHadler cHandler = new ClientHadler(clientsocket);
                    Thread t = new Thread(new ThreadStart(cHandler.chat));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
