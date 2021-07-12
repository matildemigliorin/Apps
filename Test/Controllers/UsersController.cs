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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentUser = ctx.Users.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentUser != null)
                    return View();
            }
            return View();

        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentUser = ctx.Users.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentUser != null)
                {
                    currentUser.Name = form["Name"];
                    currentUser.Surname = form["Surname"];
                    currentUser.Email = form["Email"];
                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");

        }

       
        public ActionResult Delete(int id, FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentUser = ctx.Users.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentUser != null)
                {
                    ctx.Users.Remove(currentUser);
     
                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");

        }

    }
}