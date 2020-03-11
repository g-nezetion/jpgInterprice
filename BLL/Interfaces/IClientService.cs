using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IClientService
    {
        Task Create(ClientDTO client);
        Task<List<ClientDTO>> GetClient();

    }
}
