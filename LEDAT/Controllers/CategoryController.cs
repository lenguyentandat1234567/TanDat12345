using QLTV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Category> categories = new List<Category>();
            return View(categories);
           
        }
    }
}