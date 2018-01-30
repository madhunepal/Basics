using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class webController : Controller
    {
        // GET: web/random
        public ActionResult random()
        {
            var movie = new movie() { NameValueCollectionExtensions = "Sharkk" };
            return View();
        }
    }
}