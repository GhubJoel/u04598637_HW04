using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.Controllers
{
    public class ParamedicController : Controller
    {
        // GET: Paramedic
        public ActionResult ParaIndex()
        {
            List<Paramedic> paramedics = GetTestData();
            return View(paramedics);
        }

        public ActionResult ParaReg()
        {
            return View();
        }

        private List<Paramedic> GetTestData()
        {
            List<Paramedic> paramedics = new List<Paramedic>();
            Paramedic para1 = new Paramedic("Para1", 911, "Jane", "Hobs", 29, "Female", "Paramedic");
            Paramedic para2 = new Paramedic("Para2", 911, "Matt", "Simp", 24, "Male", "Paramedic");
            Paramedic para3 = new Paramedic("Para3", 119, "Jack", "Ryan", 31, "Male", "Paramedic");
            Paramedic para4 = new Paramedic("Para4", 119, "Grace", "Oliver", 22, "Female", "Paramedic");
            paramedics.Add(para1);
            paramedics.Add(para2);
            paramedics.Add(para3);
            paramedics.Add(para4);
            return paramedics;
        }


    }
}