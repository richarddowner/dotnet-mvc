using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Name = "My Website"
            };

            return View(viewModel);
        }
    }
}