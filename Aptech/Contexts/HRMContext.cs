using Aptech.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Aptech.Contexts 
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HR_User> HR_Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.EmpId);
            modelBuilder.Entity<HR_User>().HasKey(e => e.HR_Email);
            base.OnModelCreating(modelBuilder);
        }
    }
}
