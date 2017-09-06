using System.Net;
using System.Net.Mail;

namespace Mit.Email.WebService.Services
{
    public class SmtpClientFactory : ISmtpClientFactory
    {
        public SmtpClient Create()
        {
            return new SmtpClient
            {
                EnableSsl = true,
                Credentials = new NetworkCredential
                {
                    UserName = Context.NoReplyEmailAddress,
                    Password = Context.NoReplyPassword
                },
                Port = Context.SmtpPort,
                Host = Context.SmtpServer
            };
        }
    }
}