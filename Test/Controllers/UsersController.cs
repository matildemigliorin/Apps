using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        public ActionResult Index() /*questa e' la vista collegata, quindi devo creare la vista index*/
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var users = ctx.Users.OrderBy(u=> u.Surname).ToList(); /*mi rida tutti gli users ordinati per cognome*/
                return View(users); /*richiamo la vista*/
            }
        }

        [HttpGet]
        public ActionResult Create() /*create e' la vista*/
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form) /*create e' la vista*/
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                Models.User user = new Models.User()
                {
                    Name = form["Name"],
                    Surname = form["Surname"],
                    Email = form["Email"],
                    Active = Boolean.Parse(form["Active"])
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}