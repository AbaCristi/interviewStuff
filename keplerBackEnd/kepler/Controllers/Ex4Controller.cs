using kepler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kepler.Controllers
{
    public class Ex4Controller : Controller
    {
        // GET: Ex4
        public ActionResult Index(Input input)
        {
            return View();
        }
		public ActionResult Search(object searchRequest)
		{
			return View();
		}
    }
}