using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeaCoach.Controllers
{
    public class BeaCoachController : Controller
    {
        // GET: BeaCoach
        public ActionResult Index()
        {
            return View();
        }

        //Open View for Journal
        public ActionResult BaeJournal()
        {
            return View();
        }
    }
}