namespace Levelnis.Learning.EndToEndExamples.Web.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }
    }
}