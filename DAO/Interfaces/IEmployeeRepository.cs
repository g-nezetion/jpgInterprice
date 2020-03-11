using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IEmployeeRepository
    {
        Task Create(EmployeeDTO employee);
        Task<List<EmployeeDTO>> GetEmployee();
        Task<EmployeeDTO> Authenticate(string email, string senha);
    }
}
