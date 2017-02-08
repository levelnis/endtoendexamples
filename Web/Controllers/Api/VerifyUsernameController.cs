using System.Web.Http;

namespace Levelnis.Learning.EndToEndExamples.Web.Controllers.Api
{
    public class VerifyUsernameController : ApiController
    {
        public IHttpActionResult Get(string username)
        {
            return Ok(username);
        }
    }
}
