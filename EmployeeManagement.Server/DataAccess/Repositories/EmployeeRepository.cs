using EmployeeManagement.Server.DataAccess.Context;
using EmployeeManagement.Server.DataAccess.Interfaces;
using EmployeeManagement.Server.Migrations;
using EmployeeManagement.Server.Model;
using System.Linq;

namespace EmployeeManagement.Server.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _dbContext;
        public EmployeeRepository(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetEmployee()
        {
            List<Employee> employees = new();
            return await Task.Run(() =>
            {
                employees = (from emp in _dbContext.Employees
                             select new Employee()
                             {
                                 EmpId = emp.EmpId,
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 Department = emp.Department,
                                 Position = emp.Position,
                                 Salary = emp.Salary
                             }).ToList();
                return employees;
            });

        }

        public async Task<int> CreateEmployee(Employee emp)
        {
            //Employee employee = new Employee()
            //{
            //    EmpId = emp.EmpId,
            //    FirstName = emp.FirstName,
            //    LastName = emp.LastName,
            //    Department = emp.Department,
            //    Position = emp.Position,
            //    Salary = emp.Salary

            //};
            return (int)await Task.Run(() =>
            {
                _dbContext.Add(emp);
                _dbContext.SaveChanges();
                return emp.EmpId;
            });
        }       
    }

}
