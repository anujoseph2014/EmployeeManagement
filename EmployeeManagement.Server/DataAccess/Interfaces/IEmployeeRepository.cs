using EmployeeManagement.Server.Model;

namespace EmployeeManagement.Server.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployee();
        Task<int> CreateEmployee(Employee emp);

        
    } 

}
