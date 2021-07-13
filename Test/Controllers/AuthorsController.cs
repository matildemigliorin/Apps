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
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var items = ctx.Authors.OrderBy(a => a.Name).ToList();
                return View(items);
            }
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

        public ActionResult Delete(int id, FormCollection form)
        {
            using(Models.MyContext ctx = new Models.MyContext())
            {
                var currentAuthor = ctx.Authors.Where(a => a.Id.Equals(id)).FirstOrDefault();
                if(currentAuthor != null)
                {
                    ctx.Authors.Remove(currentAuthor);
                }
                ctx.SaveChanges();
                    
             }
            return RedirectToAction("Index");
        }
    }
}