using System.Linq;
using System.Web.Mvc;
using Dapper;
using Website.Connections;
using Website.Data.Entities;
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
                var users = conn.Query<Users>(
                    sql: @"select * from Users;"
                ).ToList();
                
                var viewModel = new IndexViewModel
                {
                    Name = "My Website",
                    Users = users
                };

                return View(viewModel);
            }
        }
    }
}