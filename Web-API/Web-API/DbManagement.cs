using System.Data.Entity;

using Web_API.Models;

namespace Web_API
{
    public class DbManagement : DbContext
    {
        public DbManagement() : base("TeethManagement")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Entity<Patient>()
                .ToTable("Patient");

            modelBuilder.Entity<Patient>()
                .MapToStoredProcedures();
        }

        public DbSet<Patient> patients { get; set; }
    }
}

