using System;
using System.Net;
using System.Net.Mail;


// C#으로 Google SMTP를 이용하여 메일발송하기 

namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("구글계정@gmail.com", "비밀먼호");

                // Mail message
                var mail = new MailMessage()

                {
                    From = new MailAddress("구글계정@gmail.com"),
                    Subject = "나는 수진이야", // 메일제목
                    Body = "Test email body" // 메일 본문
                };

                mail.To.Add(new MailAddress("받는사람 이메일주소"));


                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587, // 기본포트는 정해져있음
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com", // 구글메일 주소 
                    EnableSsl = true,
                    Credentials = credentials

                };


                // Send it...         
                client.Send(mail);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;

            }

            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();

        }

    }

}