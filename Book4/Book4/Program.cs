using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

// 간단한 TCP 클라이언트,서버
// TCP Client & Server 만들기 
// 비쥬얼 스튜디오 두개 켜서 하나는 클라이언트 실행 다른하나는 서버 실행 

// Client
namespace Book4
{
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                //LocalHost에 지정 포트로 TCP Connection을 생성하고 데이터를 송수신 하기
                //위한 스트림을 얻는다. 

                client = new TcpClient();
                client.Connect("192.168.0.214", 5001);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

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
            }
        }
    }
}
