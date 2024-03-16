using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_operation_Employee.Models
{
    public partial class EmployeeModel : DbContext
    {
        public EmployeeModel()
            : base("name=EmployeeModel")
        {
        }

        public virtual DbSet<Employee_Detail> Employee_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee_Detail>()
                .Property(e => e.Employee_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Detail>()
                .Property(e => e.Employee_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Detail>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Detail>()
                .Property(e => e.Salary)
                .IsUnicode(false);
        }
    }
}
