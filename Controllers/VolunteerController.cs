using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.Controllers
{
    public class VolunteerController : Controller
    {
        // GET: Volunteer
        public ActionResult VolIndex()
        {
            List<Volunteer> volunteers = GetTestData();
            return View(volunteers);
        }

        public ActionResult VolReg()
        {
            return View();
        }

        private List<Volunteer> GetTestData()
        {
            List<Volunteer> volunteers = new List<Volunteer>();
            Volunteer vol1 = new Volunteer("Vol1", "Main Center", "Jay", "Brooks", 21, "Male", "Volunteer");
            Volunteer vol2 = new Volunteer("Vol2", "Main Center", "Zoe", "Hail", 25, "Female", "Volunteer");
            Volunteer vol3 = new Volunteer("Vol3", "SA Sub Center", "Con", "Parks", 26, "Male", "Volunteer");
            Volunteer vol4 = new Volunteer("Vol4", "SA Sub Center", "Kirsty", "Maxes", 32, "Male", "Volunteer");
            volunteers.Add(vol1);
            volunteers.Add(vol2);
            volunteers.Add(vol3);
            volunteers.Add(vol4);
            return volunteers;
        }
    }
}