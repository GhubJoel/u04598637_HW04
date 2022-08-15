using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.Controllers
{
    public class InfieldDoctorController : Controller
    {
        // GET: InfieldDoctor
        public ActionResult DocIndex()
        {
            List<InfieldDoctor> INFDoctors = GetTestData();
            return View(INFDoctors);
        }

        public ActionResult DocReg()
        {
            return View();
        }

        private List<InfieldDoctor> GetTestData()
        {
            List<InfieldDoctor> INFDoctors = new List<InfieldDoctor>();
            InfieldDoctor doc1 = new InfieldDoctor("Doc1", "Helen Josephs", "Morgan", "Parks", 45, "Female", "Doctor");
            InfieldDoctor doc2 = new InfieldDoctor("Doc2", "Helen Josephs", "Hilton", "Franks", 36, "Female", "Doctor");
            InfieldDoctor doc3 = new InfieldDoctor("Doc3", "Tigerberg Hospital", "Jason", "Mac", 55, "Male", "Doctor");
            InfieldDoctor doc4 = new InfieldDoctor("Doc4", "Tigerberg Hospital", "Lin", "King", 29, "Female", "Doctor");
            INFDoctors.Add(doc1);
            INFDoctors.Add(doc2);
            INFDoctors.Add(doc3);
            INFDoctors.Add(doc4);
            return INFDoctors;
        }
    }
}