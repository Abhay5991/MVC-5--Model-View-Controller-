using LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class IssueBookController : Controller
    {
        LibraryMVCEntities db = new LibraryMVCEntities();

        // GET: IssueBook
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GetBook()
        {
            var books = db.Book.Select(p => new
            {
                ID = p.Id,
                Bname = p.BName,

            }).ToList();

            return Json(books, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public ActionResult GetMid( int mid)
        {
            var memberid = (from s in db.Member where s.Id == mid select s.MemberName).ToList();

            return Json(memberid,JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Save(IssueBooks issue)
        {
            if (ModelState.IsValid)
            {
                db.IssueBooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(issue);
            
        }

    }
}