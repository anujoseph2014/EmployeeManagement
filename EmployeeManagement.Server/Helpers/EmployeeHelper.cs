using EmployeeManagement.Server.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Runtime.CompilerServices;

namespace EmployeeManagement.Server.Helpers
{
    public static class EmployeeHelper
    {
        public static Employee ToEntity(this EmployeeDto dto)
        {
            return new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Department = dto.Department,
                Position = dto.Position,
                Salary = dto.Salary
            };
        }
    }
}
