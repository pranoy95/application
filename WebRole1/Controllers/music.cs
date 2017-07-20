using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcApplicationDemo.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStrore
        public ActionResult Index()
        {
            return View();
        }
        public string ShowMusic(string MusicTitle)
        {
            return "You selected " + MusicTitle + " Music";
        }
    }
}
