using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PagedListController : Controller
    {
        // GET: PagedList
        private DBContext _db = new DBContext();

        protected override void Dispose(bool disposing)
        {          
            if (disposing)
            {
                _db.Dispose(); 
            }
            base.Dispose(disposing);

        }
        public ActionResult Index(int page = 1, int pageSize = 15)
        {
            var ListAll = from m in _db.Orders
                               select m;

            var pagelist= ListAll.ToList().ToPagedList(page, pageSize);

            return View(pagelist);
        }
    }
}