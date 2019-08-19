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
        public ActionResult BaeLogin()
        {
            return View();
        }
        public ActionResult BaeProfile()
        {
            return View();
        }

        public ActionResult BaeScopes()
        {
            return View();
        }
        //Open View for Journal
        public ActionResult BaeJournal()
        {
            return View();
        }
        public ActionResult Calender()
        {
            return View();
        }
        //Open View for found Journal
        public ActionResult FindJournalEntry()
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

        public ActionResult UpdateInfo()
        {
            return View();
        }

        public ActionResult DateIdeas()
        {
            return View();
        }

        public ActionResult RomanticDinner()
        {
            return View();
        }
        public ActionResult BaeGifts()
        {
            return View();
        }
        public ActionResult BaeAdvice()
        {
            return View();
        }
        public ActionResult BaeAdviceSingle()
        {
            return View();
        }
        public ActionResult BaeAdviceMarried()
        {
            return View();
        }
        public ActionResult BaeAdviceRelationship()
        {
            return View();
        }
    }
}