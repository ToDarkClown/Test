using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RNT.Controllers
{
    public class LARController : Controller
    {
        // GET: LAR
        /// <summary>
        /// Login And Register
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}