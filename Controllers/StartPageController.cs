using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Episerver9.Models.Pages;
using EPiServer.Web.Mvc;

namespace Episerver9.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}