using Mic.Volo.Async_ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Mic.Volo.Async_ASP.Controllers
{
    public class HomeController : Controller
    {
        TodoContext db = new TodoContext();
        public ActionResult Index()
        {
            IEnumerable<ToDo> toDos =  db.ToDos.ToList();
            ViewBag.Todos = toDos;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public async Task<ActionResult> TodoList()
        {
            IEnumerable<ToDo> toDos = await db.ToDos.ToListAsync();
            ViewBag.Todos = toDos;
            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}