using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Knockout.Models;

namespace Knockout.Controllers
{
    public class KnockController : Controller
    {
        //
        // GET: /Knock/

        public ActionResult Index()
        {
            return View("KnockView", new KnockModel());
        }

    }
}
