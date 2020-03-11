using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private JPGContext _contex;
        public EmployeeRepository(JPGContext context)
        {
            this._contex = context;
        }

        public async Task<EmployeeDTO> Authenticate(string email, string senha)
        {
            EmployeeDTO user = null;
            try
            {
                user = await _contex.Employees.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Senha.Equals(senha));

            }
            catch (Exception ex)
            {
                throw new Exception("Erro no bd contate o adm blza? s2");
            }

            if (user == null)
            {
                throw new Exception("Email e/ou senhas inválidos.");
            }
            return user;
        }

        public async Task Create(EmployeeDTO employee)
        {
            this._contex.Employees.Add(employee);
            await this._contex.SaveChangesAsync();
        }

        public async Task<List<EmployeeDTO>> GetEmployee()
        {
            return await _contex.Employees.ToListAsync();
        }
    }
}
