using QLTV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTV.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Product> Products = new List<Product>();
            return View(Products);

        }
    }
}