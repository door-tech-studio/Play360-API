using play_360.Services.Abstration.Messaging;
using System.Net;
using System.Net.Mail;

namespace play_360.Services.Concrete.Messaging
{
    public class EmailMessager : IEmailMessager
    {
        public void SendEmail(string toAddress, string subject, string body)
        {
            try
            {
                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("bsngema7@gmail.com", "*EmaNgadini96#");
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;

                    using (var mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("bsngema7@gmail.com");
                        mailMessage.To.Add(toAddress);
                        mailMessage.Subject = subject;
                        mailMessage.Body = body;

                        smtpClient.Send(mailMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }
    }
}
