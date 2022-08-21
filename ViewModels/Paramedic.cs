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

        public Paramedic(string ID, int ambnr, string firstName, string lastName, int age, string gender, string profession) : base(ID, firstName, lastName, age, gender,profession)
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
            return base.DispInfo() + " " + " With Ambulance Number : " + AmbulanceNr;
        }


    }
}