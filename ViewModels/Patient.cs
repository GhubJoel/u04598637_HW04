using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u04598637_HW04.ViewModels
{
    public class Patient
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }

        public Patient()
        {
            this.ID = Guid.NewGuid();
        }

        public Patient(string fn, string ln, int ag, string ge, string st, string loc)
        {
            this.ID = Guid.NewGuid();
            this.FirstName = fn;
            this.LastName = ln;
            this.Age = ag;
            this.Gender = ge;
            this.Status = st;
            this.Location = loc;
        }

        public Patient Clone()
        {
            return new Patient
            {
                ID = this.ID,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Gender = this.Gender,
                Status = this.Status,
                Location = this.Location,
            };
        }

        public void Copy(Patient patient)
        {
            this.FirstName = patient.FirstName;
            this.LastName = patient.LastName;
            this.Age = patient.Age;
            this.Gender = patient.Gender;
            this.Status = patient.Status;
            this.Location = patient.Location;
        }
    }
}