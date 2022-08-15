using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u04598637_HW04.ViewModels
{
    public class Volunteer : Worker
    {
        private string _helpCen;

        public Volunteer(string ID, string helpcenter, string firstName, string lastName, int age, string gender, string profession) : base(ID, firstName, lastName, age, gender, profession)
        {
            _helpCen = helpcenter;
        }

        public string HelpCenter
        {
            get { return _helpCen; }
            set { _helpCen = value; }
        }

        public override string DispInfo()
        {
            return base.DispInfo() + "Working with us from " + HelpCenter;
        }
    }
}