using System;
using System.Collections.Generic;
using EFDummyCompany.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFDummyCompany.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("name=CompanyContext")
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<WorksOn> WorksOn { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.WorksOn)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.WorksOn)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(true);
        }

        }
}