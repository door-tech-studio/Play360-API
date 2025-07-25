namespace play_360.Services.Abstration.Messaging
{
    public interface IEmailMessager
    {
        public void SendEmail(string toAddress, string subject, string body);
    }
}
