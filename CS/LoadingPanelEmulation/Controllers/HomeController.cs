using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace LoadingPanelEmulation.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            //Additional time for demonstrating functionality of the solution
            Thread.Sleep(2000);
            return View();
        }
    }
}
