using System.ComponentModel.DataAnnotations;

namespace Mit.Email.WebService.Models
{
    public class EmailRequest
    {
        public string DomainName { get; set; }

        public string Name { get; set; }

        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "EmailAddress должен быть указан.")]
        [EmailAddress(ErrorMessage = "EmailAddress должен быть указан в правильном формате.")]
        public string EmailAddress { get; set; }

        public string Message { get; set; }
    }
}