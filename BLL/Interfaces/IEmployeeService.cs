using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployeeService
    {
        Task Create(EmployeeDTO employee);
        Task<List<EmployeeDTO>> GetEmployee();
        Task<EmployeeDTO> Autententicar(string email, string password);
    }
}
