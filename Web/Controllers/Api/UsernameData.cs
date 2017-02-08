namespace Levelnis.Learning.EndToEndExamples.Web.Controllers.Api
{
    using System.Collections.Generic;

    public class UsernameData
    {
        public const string DataSource = @"
{
  ""Usernames"":[
    ""smiler"",
    ""dave.smith"",
    ""happygolucky17"",
    ""tom2017"",
    ""ab1234"",
  ]
}";
        public IList<string> Usernames { get; set; }
    }
}