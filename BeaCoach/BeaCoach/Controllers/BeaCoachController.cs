﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeaCoach.Controllers
{
    public class BeaCoachController : Controller
    {
        // GET: BeaCoach
        public ActionResult BaeLogin()
        {
            return View();
        }

        //Open View for Journal
        public ActionResult BaeJournal()
        {
            return View();
        }

        //open view for quizzes
        public ActionResult BaeQuizzes()
        {
            return View();
        }

        public ActionResult BaeSignUp()
        {
            return View();
        }
        public ActionResult BaeHome()
        {
            return View();
        }
    }
}