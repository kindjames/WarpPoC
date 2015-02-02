using System;
using System.Collections.Generic;
using hGem.Core.Services.Dtos.Client;

namespace hGem.Core.Services
{
    public interface IClientService
    {
        ClientDto GetClient(Guid clientId);
        void SaveClient(SaveClientDto dto);
        IEnumerable<ClientDto> GetClients(string clientNameQuery, Guid customerId);
    }
}