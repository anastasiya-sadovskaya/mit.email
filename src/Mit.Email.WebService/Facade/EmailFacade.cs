using Mit.Email.WebService.Models;
using Mit.Email.WebService.Services;
using Mit.Email.WebService.Translators;

namespace Mit.Email.WebService.Facade
{
    public sealed class EmailFacade
    {
        private readonly IEmailService emailService;

        public EmailFacade(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void SendEmail(EmailRequest request)
        {
            var emailData = EmailRequestTranslator.Map(request);
            this.emailService.SendEmail(emailData);
            this.emailService.AddEmail(emailData);
        }
    }
}