using System;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace Mit.Email.WebService.Repository
{
    public class EmailRepository : IEmailRepository
    {
        public void AddEmail(Domain.Models.EmailData emailData)
        {
            File.WriteAllText(Path.Combine(ConfigurationManager.AppSettings["StorageFolder"], Guid.NewGuid().ToString()),
                JsonConvert.SerializeObject(emailData));
        }
    }
}