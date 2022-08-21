using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u04598637_HW04.ViewModels;

namespace u04598637_HW04.ViewModels
{
    public class PatientList
    {
        private static List<Patient> Patients = new List<Patient>
        {
            new Patient("Charles", "Barry", 21, "Male", "Minor Injuries", "Tigerberg Hospital"),
             new Patient("Zia", "Meyer", 29, "Femaale", "Critical", "Helen Joseheps Hospital"),
        };

        public static Patient GetPatients(Guid id)
        {
            foreach(Patient patient in Patients)
            {
                if(patient.ID.Equals(id))
                {
                    return patient.Clone();
                }
            }
            return null;
        }

        public static Patient Patient(Guid id)
        {
            foreach (Patient patient in Patients)
            {
                if (patient.ID.Equals(id))
                {
                    return patient;
                }
            }
            return null;
        }

        public static List<Patient> GetPatients()
        {
            return Patients;
        }

        public static void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public static void DeletePatient(Guid id)
        {
            Patients.Remove(Patient(id));
        }

        public static void UpdatePatient(Patient patient)
        {
            Patient old = Patient(patient.ID);
            old.Copy(patient);
        }
    }
}