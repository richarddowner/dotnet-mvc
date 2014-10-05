using System.Web.Mvc;
using Website.Connections;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            using (var conn = new MyDbConnection().Open())
            {
                var sql = @"select * from todo";
                
                // conn.Query ?
            }

            var viewModel = new IndexViewModel
            {
                Name = "My Website"
            };

            return View(viewModel);
        }
    }
}