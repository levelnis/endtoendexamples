using System.Web.Http;

namespace Levelnis.Learning.EndToEndExamples.Web.Controllers.Api
{
    public class UsernameController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("OK");
        }
    }
}
