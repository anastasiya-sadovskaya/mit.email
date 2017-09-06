using Microsoft.Practices.Unity;
using System.Web.Http;
using Mit.Email.WebService.Repository;
using Mit.Email.WebService.Services;
using Unity.WebApi;

namespace Mit.Email.WebService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IEmailService, EmailService>(new HierarchicalLifetimeManager());
            container.RegisterType<IEmailRepository, EmailRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ISmtpClientFactory, SmtpClientFactory>(new HierarchicalLifetimeManager());
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}