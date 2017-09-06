using System.Net.Mail;

namespace Mit.Email.WebService.Services
{
    public interface ISmtpClientFactory
    {
        SmtpClient Create();
    }
}