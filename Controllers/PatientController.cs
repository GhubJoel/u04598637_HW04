using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult PatIndex()
        {
            return View(PatientList.GetPatients());
        }

        public ActionResult PatDisplay()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddPatient()
        {
            return View(new Patient());
        }

        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
            PatientList.AddPatient(patient);
            return RedirectToAction("PatIndex");
        }

        public ActionResult DeletePatient(Guid id)
        {
            PatientList.DeletePatient(id);
            return RedirectToAction("PatIndex");
        }

        [HttpGet]
        public ActionResult UpdatePatient(Guid id)
        {
            return View(PatientList.GetPatients(id));
        }

        [HttpPost]
        public ActionResult UpdatePatient(Patient patient)
        {
            PatientList.UpdatePatient(patient);
            return RedirectToAction("PatIndex");
        }
    }
}