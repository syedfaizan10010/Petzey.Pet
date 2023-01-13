using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Domain.Entities
{
    public class Patient
    {
        [Key]
        public int petId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public Gender gender { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string ownerEmail { get; set; }
        public string ownerPhoneNo { get; set; }
        public string avatar { get; set; }
        public Status status { get; set; }

        //Enumaration class
        public enum Gender
        {
            Male,
            Female
        }
        public enum Status
        {
            Active =1,
            InActive
        }
    }
}
