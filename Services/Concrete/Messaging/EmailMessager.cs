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
                using (var smtpClient = new SmtpClient("smtp.example.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("username", "password");
                    smtpClient.EnableSsl = true;

                    using (var mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("sender@example.com");
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
