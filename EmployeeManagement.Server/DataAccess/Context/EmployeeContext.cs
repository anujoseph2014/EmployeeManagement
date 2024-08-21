using EmployeeManagement.Server.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace EmployeeManagement.Server.DataAccess.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { 
        
        }
        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
            });           
        }

    }
}
