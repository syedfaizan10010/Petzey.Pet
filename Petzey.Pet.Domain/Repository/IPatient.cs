using Petzey.Pet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Domain.Repository
{
    public interface IPatient
    {
        void AddNewPet(Patient patient);

        List<Patient> GetPatient();//For List View
        Patient GetPatientById(int id); //For Card View

        void UpdatePatient(Patient patient, int petId); //For editing the patient details
        void DeletePatient(int id); //For Deleting any Patient profile

        void DeActivate(int id);
    }
}
