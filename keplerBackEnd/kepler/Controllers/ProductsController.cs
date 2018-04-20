using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kepler.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Search(string search)
        {
			//parse and do stuff with search criteria
            return View();
        }
    }
}