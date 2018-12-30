//이메일을 구글 계정을 통해 SMTP 로 보내고자 할때는 구글에 로그인 후 계정의 설정, 로그인/
//보안(https://myaccount.google.com/security) 에서 하단의 "보안수준이 낮은 앱 허용"을 "사용"으로
//설정해야 한다.
using System;
using System.Net;
using System.Net.Mail;
namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Credentials
             var credentials = new NetworkCredential("구글계정@gmail.com", "비번");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("구글계정@gmail.com"),
                    Subject = "Test email.",
                    Body = "Test email body"
                };
                mail.To.Add(new MailAddress("받는사람 이메일주소"));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
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