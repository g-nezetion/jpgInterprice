using BLL.Interfaces;
using Common;
using DAO;
using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL.Impl
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository repo)
        {
            this.employeeRepository = repo;
        }

        public async Task<EmployeeDTO> Autenticar(string email, string password)
        {
            return await employeeRepository.Authenticate(email, password);
        }


        public async Task Create(EmployeeDTO employee)
        {
            if (employee.Nome == "")
            {
                throw new Exception("o nome deve ser informado");
            }
            else
            {
                employee.Nome = employee.Nome.Trim();

                if (employee.Nome.Length < 2 || employee.Nome.Length > 50)
                {
                    throw new Exception("o nome deve conter de 2 a 50 caracteres");
                }
            }
            if (employee.Email == "")
            {
                throw new Exception("o email deve ser informada");
            }
            else
            {
                if (employee.Email.Length < 2 || employee.Email.Length > 100)
                {
                    throw new Exception("o email deve conter de 2 a 100 caracteres");
                }
            }
            if (employee.CPF == "")
            {
                throw new Exception("o cpf deve ser informada");
            }
            else
            {
                if (employee.CPF.Length != 14)
                {
                    throw new Exception("o cpf deve conter 14 caracteres");
                }
            }
            await employeeRepository.Create(employee);

        }

        public async Task<List<EmployeeDTO>> GetEmployee()
        {
            try
            {
                return await employeeRepository.GetEmployee();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);

                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }
    }
}
