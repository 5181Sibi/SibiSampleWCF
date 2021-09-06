using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SibiSampleWCF.ProductService;

namespace SibiSampleWCF.Controllers
{
    public class ProductController : Controller
    {
        private SibiSampleWCFClient psc = new SibiSampleWCFClient();
        public ActionResult Index()
        {
            ViewBag.listProducts = psc.findAll();
            return View();
        }

        public ActionResult Search(FormCollection fc)
        {
            string condition = fc["condition"];
            string keyword = fc["keyword"];
            if (condition.Equals("byID"))
                ViewBag.listProducts = psc.find(Convert.ToInt32(keyword));
            else
                ViewBag.listProducts = psc.findByDate(Convert.ToDateTime(keyword));
            return View("Index");
        }
    }
}