﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTV.Models;

namespace QLTV.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();   
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}