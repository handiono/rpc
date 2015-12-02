using Library.Entities;
using Lybrary.Web.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lybrary.Web.Controllers
{
    public class AllDataController : Controller
    {

        private LibraryDb db = new LibraryDb();

        // GET: AllData
        public ActionResult Index()
        {

            string query = "select * from Books";
            IEnumerable<Book> data = db.Database.SqlQuery<Book>(query);
            ViewBag.book = data.ToList();


            string query1 = "select * from Members";
            IEnumerable<Member> data1 = db.Database.SqlQuery<Member>(query1);
            ViewBag.member = data1.ToList();

            return View();
        }
    }
}