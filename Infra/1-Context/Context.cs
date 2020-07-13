using Domain.User;
using Infra._1_Mappimg;
using Infra._1_Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra._1_Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new ManagerMapping());
            modelBuilder.ApplyConfiguration(new SupervisorMapping());
            base.OnModelCreating(modelBuilder);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
