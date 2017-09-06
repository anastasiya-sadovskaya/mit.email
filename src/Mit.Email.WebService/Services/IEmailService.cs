namespace Mit.Email.WebService.Services
{
    public interface IEmailService
    {
        void AddEmail(Domain.Models.EmailData emailData);

        void SendEmail(Domain.Models.EmailData emailData);
    }
}