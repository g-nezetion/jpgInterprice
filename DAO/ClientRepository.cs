using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClientRepository : IClientRepository
    {
        private JPGContext _contex;
        public ClientRepository(JPGContext context)
        {
            this._contex = context;
        }

        public async Task Create(ClientDTO client)
        {
            this._contex.Clients.Add(client);
            await this._contex.SaveChangesAsync();
        }

        public async Task<List<ClientDTO>> GetClients()
        {
                return await _contex.Clients.ToListAsync();
        }
    }
}
