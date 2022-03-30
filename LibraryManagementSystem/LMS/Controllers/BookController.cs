using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LMS.Models;

namespace LMS.Controllers
{
    public class BookController : Controller
    {
        private LibraryMVCEntities db = new LibraryMVCEntities();

        // GET: Book
        public ActionResult Index()
        {
            var book = db.Book.Include(b => b.Author).Include(b => b.Category).Include(b => b.Publisher);
            return View(book.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            ViewBag.a_id = new SelectList(db.Author, "Id", "AuthorName");
            ViewBag.Cat_id = new SelectList(db.Category, "Id", "CatName");
            ViewBag.p_id = new SelectList(db.Publisher, "Id", "PubName");
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BName,Cat_id,a_id,p_id,Contents,Pages,Edition")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Book.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.a_id = new SelectList(db.Author, "Id", "AuthorName", book.a_id);
            ViewBag.Cat_id = new SelectList(db.Category, "Id", "CatName", book.Cat_id);
            ViewBag.p_id = new SelectList(db.Publisher, "Id", "PubName", book.p_id);
            return View(book);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.a_id = new SelectList(db.Author, "Id", "AuthorName", book.a_id);
            ViewBag.Cat_id = new SelectList(db.Category, "Id", "CatName", book.Cat_id);
            ViewBag.p_id = new SelectList(db.Publisher, "Id", "PubName", book.p_id);
            return View(book);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BName,Cat_id,a_id,p_id,Contents,Pages,Edition")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.a_id = new SelectList(db.Author, "Id", "AuthorName", book.a_id);
            ViewBag.Cat_id = new SelectList(db.Category, "Id", "CatName", book.Cat_id);
            ViewBag.p_id = new SelectList(db.Publisher, "Id", "PubName", book.p_id);
            return View(book);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Book.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Book.Find(id);
            db.Book.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
