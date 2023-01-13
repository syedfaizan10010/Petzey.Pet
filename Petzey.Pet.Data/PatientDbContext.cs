using Microsoft.EntityFrameworkCore;
using Petzey.Pet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Pet.Data
{
    internal class PatientDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PatientData;Integrated Security=True");
        }
        public DbSet<Patient> Patients { get; set; }

    }
}
