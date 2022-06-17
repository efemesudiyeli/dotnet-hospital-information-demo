using System;
using Microsoft.EntityFrameworkCore;

namespace hospitalinformationsystem.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server=MSI; database=hospitalinfosystem; integrated security=true;");
        }

        public DbSet<PatientInfoModel>? patientInfoModels { get; set; }
        public DbSet<StaffModel>? staffModels { get; set; }
    }
}
