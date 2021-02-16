using Audit.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audit.DataAccess.Concrete.EntityFramework
{
   public class AuditContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS; Database = Audit; Trusted_Connection=true");
        }
        public DbSet<Person> Persons{ get; set; }
        public DbSet<HealthcareProvider> HealthcareProviders { get; set; }
        public DbSet<Petition> Petitions{ get; set; }
        public DbSet<PetitionDetail> PetitionDetails{ get; set; }
        public DbSet<Report> Reports{ get; set; }
        public DbSet<ReportDetail> ReportDetails{ get; set; }
        public DbSet<User> Users { get; set; }
    }
}
