using LMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{

    public class ReturnBookController : Controller
    {
        LibraryMVCEntities db = new LibraryMVCEntities();

        // GET: ReturnBook
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(ReturnBookModel returnBookModel)
        {

            returnBookModel.returndate = Convert.ToDateTime(returnBookModel.returndate);

            if (ModelState.IsValid)
            {
                ReturnBook returnBook = new ReturnBook()
                {
                    id = returnBookModel.id,
                    mid = returnBookModel.mid,
                    book = returnBookModel.book,
                    returndate = DateTime.Now,
                    fine = returnBookModel.fine,
                    elap = returnBookModel.elap
                };

                db.ReturnBook.Add(returnBook);
                db.SaveChanges();
                return View();
            }
            return View(returnBookModel);
        }


        public ActionResult GetMid(int mid)
        {

            var memberid = (from s in db.IssueBooks
                            where s.m_id == mid
                            select new
                            {
                                IssueDate = s.issuedate,
                                ReturnDate = s.returndate,
                                MemberId = s.m_id,
                                BookName = s.book_id,
                                ElapsedDays = SqlFunctions.DateDiff("day", s.returndate, DateTime.Now)

                            }).ToArray();

            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

    }



}