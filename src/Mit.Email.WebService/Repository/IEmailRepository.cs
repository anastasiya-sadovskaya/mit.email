namespace Mit.Email.WebService.Repository
{
    public interface IEmailRepository
    {
        void AddEmail(Domain.Models.EmailData emailData);
    }
}