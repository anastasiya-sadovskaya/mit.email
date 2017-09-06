using Mit.Email.WebService.Models;

namespace Mit.Email.WebService.Translators
{
    public static class EmailRequestTranslator
    {
        public static Domain.Models.EmailData Map(EmailRequest request)
        {
            return new Domain.Models.EmailData
            {
                DomainName = request.DomainName,
                Name = request.Name,
                EmailAddress = request.EmailAddress,
                Message = request.Message,
                MobilePhone = request.MobilePhone
            };
        }
    }
}