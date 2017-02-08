namespace Levelnis.Learning.EndToEndExamples.Web.Controllers.Api
{
    using System.Linq;
    using System.Web.Http;
    using Newtonsoft.Json;

    public class VerifyUsernameController : ApiController
    {
        public IHttpActionResult Get(string username)
        {
            var usernameData = JsonConvert.DeserializeObject<UsernameData>(UsernameData.DataSource);
            var usernames = usernameData.Usernames.Select(x => x.ToLower());
            var isUsernameTaken = usernames.Contains(username.ToLower());
            var response = new VerifyUsernameResponse
            {
                OriginalUsername = username,
                IsAvailable = !isUsernameTaken
            };
            return Ok(response);
        }
    }
}