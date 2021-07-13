 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            using( Models.MyContext ctx = new Models.MyContext())
            {
                var items = ctx.Books.OrderBy(b => b.Title).ToList();
                    return View(items);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View(); 

        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                Models.Book book = new Models.Book()
                {
                    Title = form["Name"],
                    Author = form["Author"],
                    ISBN = form["ISBN"],
                    Available = Boolean.Parse(form["Available"])
                };
                ctx.Books.Add(book);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
                
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentBook = ctx.Books.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentBook != null)
                    return View();
            }
            return View();

        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentBook = ctx.Books.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentBook != null)
                {
                    currentBook.Title = form["Title"];
                    currentBook.Author = form["Author"];
                    currentBook.ISBN = form["ISBN"];
                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id, FormCollection form)
        {
            using (Models.MyContext ctx = new Models.MyContext())
            {
                var currentBook = ctx.Books.Where(u => u.ID.Equals(id)).FirstOrDefault();
                if (currentBook != null)
                {
                    ctx.Books.Remove(currentBook);

                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");

        }


    }
}