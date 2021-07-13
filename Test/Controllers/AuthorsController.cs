using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View(); /*richiamo la vista*/

        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                Models.Author author = new Models.Author()
                {
                    Name = form["Name"],
                    Surname = form["Surname"]
                };
                ctx.Authors.Add(author);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}