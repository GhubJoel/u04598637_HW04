using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u04598637_HW04.ViewModels
{
    public class InfieldDoctor : Worker
    {
        private string _hospital;

        public InfieldDoctor(string ID, string hospital, string firstName, string lastName, int age, string gender, string profession) : base(ID, firstName, lastName, age, gender, profession)
        {
            _hospital = hospital;
        }

        public string Hospital
        {
            get { return _hospital; }
            set { _hospital = value; }
        }

        public override string DispInfo()
        {
            return base.DispInfo() + " " + "Working with us from : " + Hospital;
        }
    }
}