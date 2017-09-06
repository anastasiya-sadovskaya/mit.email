using System.Configuration;

namespace Mit.Email.WebService
{
    public static class Context
    {
        public static string NoReplyEmailAddress
        {
            get { return ConfigurationManager.AppSettings["NoReplyEmailAddress"]; }
        }

        public static string NoReplyPassword
        {
            get { return ConfigurationManager.AppSettings["NoReplyPassword"]; }
        }

        public static string BccRecipients
        {
            get { return ConfigurationManager.AppSettings["BccRecipients"]; }
        }

        public static string To
        {
            get { return ConfigurationManager.AppSettings["To"]; }
        }

        public static string SmtpServer
        {
            get { return ConfigurationManager.AppSettings["SmtpServer"]; }
        }

        public static int SmtpPort
        {
            get { return int.Parse(ConfigurationManager.AppSettings["SmtpPort"]); }
        }
    }
}