using System.Net.Http;
using System.Web.Http;
using Mit.Email.WebService.Facade;
using Mit.Email.WebService.Models;

namespace Mit.Email.WebService.Controllers
{
    public class EmailController : ApiController
    {
        [HttpPost]
        [Route("v1/email")]
        public IHttpActionResult SendEmail(EmailRequest request)
        {
            var facade = (EmailFacade)this.Request.GetDependencyScope().GetService(typeof (EmailFacade));
            facade.SendEmail(request);
            return this.Ok();
        }
    }
}