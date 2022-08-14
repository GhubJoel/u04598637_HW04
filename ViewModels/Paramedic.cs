using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u04598637_HW04.ViewModels
{
    public class Paramedic : Worker
    {
        // GET: Paramedic
        private int _AmbNr;

        public Paramedic(int ID, int ambnr, string firstName, string lastName, int age, string profession) : base(ID, firstName, lastName, age,profession)
        {
            _AmbNr = ambnr;
        }

        public int AmbulanceNr
        {
            get { return _AmbNr; }
            set { _AmbNr = value; }
        }

        public override string DispInfo()
        {
            return base.DispInfo() + "Ambulance Number : " + AmbulanceNr;
        }


    }
}