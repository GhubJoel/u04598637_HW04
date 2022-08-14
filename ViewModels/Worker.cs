using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u04598637_HW04.ViewModels
{
    public abstract class Worker 
    {
        private int _ID;
        private string _FirstName;
        private string _LastName;
        private int _Age;
        private string _Profession;
       // private string _Image;

        public Worker(int ID, string firstName, string lastName, int age, string profession)
        {
            _ID = ID;
            _FirstName = firstName;
            _LastName = lastName;
            _Age = age;
            _Profession = profession;
           // _Image = image;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }

        /*
        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }
        */
        public virtual string DispInfo()
        {
            return FirstName + LastName + " is " + Age.ToString() + " years old." + " and a " + Profession + "for ICRC Hope Center";
        }

    }
}