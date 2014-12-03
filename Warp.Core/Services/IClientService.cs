using System.Collections.Generic;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Services
{
    public interface IClientService
    {
        ClientDto GetClient(int clientId);
        void SaveClient(SaveClientDto dto);
        IEnumerable<ClientDto> GetClients(string clientNameQuery, int userId, int customerId);
    }
}