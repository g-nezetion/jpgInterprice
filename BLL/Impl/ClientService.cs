using BLL.Interfaces;
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
    public class ClientService : BaseService, IClientService
    {

        private IClientRepository _clientRepository;
        public ClientService(IClientRepository clientrepository)
        {
            this._clientRepository = clientrepository;

        }

        public async Task Create(ClientDTO client)
        {
            if (client.Name == "")
            {
                throw new Exception("o nome deve ser informado");
            }
            else
            {
                client.Name = client.Name.Trim();
                client.Name = Regex.Replace(client.Name, @"\s+", " ");

                if (client.Name.Length < 2 || client.Name.Length > 50)
                {
                    throw new Exception("o nome deve conter de 2 a 50 caracteres");
                }
            }
            if (client.Email == "")
            {
                throw new Exception("o email deve ser informado");
            }
            else
            {
                if (client.Email.Length < 2 || client.Email.Length > 100)
                {
                    throw new Exception("o email deve conter de 2 a 100 caracteres");
                }
            }
            await _clientRepository.Create(client);

        }

        public async Task<List<ClientDTO>> GetClient()
        {
            try
            {
                return await _clientRepository.GetClients();
            }
            catch (Exception ex)
            {
                File.WriteAllText("log.txt", ex.Message + " - " + ex.StackTrace);
                throw new Exception("Erro no banco de dados, contate o administrador");
            }
        }
    }



}

