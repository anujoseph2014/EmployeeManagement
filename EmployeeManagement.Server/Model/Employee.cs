using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Server.Model
{
    public class Employee
    {
        [Key]
        [Column("empId")]
        public int? EmpId {  get; set; }
        [Column("firstName")]
        public string? FirstName { get; set; }
        [Column("lastName")]
        public string? LastName { get; set; }
        [Column("position")]
        public string? Position { get; set; }
        [Column("department")]
        public string? Department { get; set; }
        [Column("salary")]
        public int? Salary { get; set; }
    }
}
