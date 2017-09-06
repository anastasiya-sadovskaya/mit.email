using System;
using System.Linq;
using System.Net.Mail;
using Mit.Email.WebService.Domain.Models;
using Mit.Email.WebService.Repository;

namespace Mit.Email.WebService.Services
{
    public class EmailService : IEmailService
    {
        private readonly ISmtpClientFactory smtpClientFactory;
        private readonly IEmailRepository emailRepository;

        public EmailService(ISmtpClientFactory smtpClientFactory, IEmailRepository emailRepository)
        {
            this.smtpClientFactory = smtpClientFactory;
            this.emailRepository = emailRepository;
        }

        public void AddEmail(Domain.Models.EmailData emailData)
        {
            this.emailRepository.AddEmail(emailData);
        }

        public void SendEmail(Domain.Models.EmailData emailData)
        {
            using (var smtpClient = this.smtpClientFactory.Create())
            {
                smtpClient.Send(EmailService.CreateMailMessage(emailData));   
            }
        }

        private static MailMessage CreateMailMessage(EmailData emailData)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(Context.NoReplyEmailAddress),
                Subject = "Новый заказ",
                Body = EmailService.GenerateMailMessageBody(emailData)
            };

            foreach (var m in Context.BccRecipients.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries).Select(e => new MailAddress(e)))
            {
                mailMessage.Bcc.Add(m);
            }

            mailMessage.To.Add(new MailAddress(Context.To));

            return mailMessage;
        }

        private static string GenerateMailMessageBody(EmailData emailData)
        {
            return string.Format("Сайт : {5}{1}Имя: {0}{1}Контактный телефон: {2}{1}Email: {3}{1}Сообщение: {4}",
                emailData.Name,
                Environment.NewLine,
                emailData.MobilePhone,
                emailData.EmailAddress,
                emailData.Message,
                emailData.DomainName);
        }
    }
}