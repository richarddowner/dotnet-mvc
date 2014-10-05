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
                const string sql = @"select * from todo where blah = @Blah";
                
                var result = conn.Query<string>(
                    sql:sql,
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