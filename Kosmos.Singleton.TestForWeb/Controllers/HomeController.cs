using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Kosmos.Singleton.TestForWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            SingleHttpClient.PostException(new { test = "yongsheng_web", date = DateTime.Now });
            //Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            return View();
        }
    }
}
