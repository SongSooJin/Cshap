using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

// 콘솔기반의 채팅 프로그램
// 비쥬얼 스튜디오 두개 켜서 하나는 클라이언트 실행 다른하나는 서버 실행 

// 클라이언트 

namespace ConsoleApp5
{
    class ServerHandler
    {
        StreamReader reader = null;
        public ServerHandler(StreamReader reader) {
            this.reader = reader;
        }

        // 서버에서 불특정하게 날아오는 다른 Client가 쓴 내용을 받기 위해
        // 클라이언트의 글읽는 부분을 쓰레드로 처리 
        public void chat() {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class TcpClientTest {
        static void Main(string[] args) {
            TcpClient client = null;
            try
            {
                // LocalHost에 지정 포트로 TCP Connection을 생성하고 데이터를 송수신 하기
                //위한 스트림을 얻는다. 

                client = new TcpClient();
                client.Connect("192.168.0.15", 5001);
                NetworkStream stream = client.GetStream();

                Encoding encode = Encoding.GetEncoding("utf-8");

                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream, encode) { AutoFlush = true };

                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.chat));
                t.Start();

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    if (dataToSend.IndexOf("<EOF>") > -1) break;
                    dataToSend = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                client.Close();
                client = null;
            }
        }
    }

}

