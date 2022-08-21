using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult WorkIndex()
        {
            List<Worker> workers = new List<Worker>();
            Paramedic para1 = new Paramedic("Para1", 911, "Jane", "Hobs", 29, "Female", "Paramedic");
            Paramedic para2 = new Paramedic("Para2", 911, "Matt", "Simp", 24, "Male", "Paramedic");
            Paramedic para3 = new Paramedic("Para3", 119, "Jack", "Ryan", 31, "Male", "Paramedic");
            Paramedic para4 = new Paramedic("Para4", 119, "Grace", "Oliver", 22, "Female", "Paramedic");
            InfieldDoctor doc1 = new InfieldDoctor("Doc1", "Helen Josephs", "Morgan", "Parks", 45, "Female", "Doctor");
            InfieldDoctor doc2 = new InfieldDoctor("Doc2", "Helen Josephs", "Hilton", "Franks", 36, "Female", "Doctor");
            InfieldDoctor doc3 = new InfieldDoctor("Doc3", "Tigerberg Hospital", "Jason", "Mac", 55, "Male", "Doctor");
            InfieldDoctor doc4 = new InfieldDoctor("Doc4", "Tigerberg Hospital", "Lin", "King", 29, "Female", "Doctor");
            Volunteer vol1 = new Volunteer("Vol1", "Main Center", "Jay", "Brooks", 21, "Male", "Volunteer");
            Volunteer vol2 = new Volunteer("Vol2", "Main Center", "Zoe", "Hail", 25, "Female", "Volunteer");
            Volunteer vol3 = new Volunteer("Vol3", "SA Sub Center", "Con", "Parks", 26, "Male", "Volunteer");
            Volunteer vol4 = new Volunteer("Vol4", "SA Sub Center", "Kirsty", "Maxes", 32, "Male", "Volunteer");
            workers.Add(para1);
            workers.Add(para2);
            workers.Add(doc1);
            workers.Add(doc2);
            workers.Add(vol1);
            workers.Add(vol2);
            workers.Add(para3);
            workers.Add(para4);
            workers.Add(doc3);
            workers.Add(doc4);
            workers.Add(vol3);
            workers.Add(vol4);
            return View(workers);
        }
    }
}