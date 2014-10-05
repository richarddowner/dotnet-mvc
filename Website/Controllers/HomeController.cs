using System.Linq;
using System.Web.Mvc;
using Dapper;
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
                var result = conn.Query<string>(
                    sql: @"select * from todo where blah = @Blah",
                    param: new
                    {
                        @Blah = "hi"
                    }
                ).ToList();
            }

            var viewModel = new IndexViewModel
            {
                Name = "My Website"
            };

            return View(viewModel);
        }
    }
}