using System;
using System.Collections.Generic;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Services
{
    public interface IClientService
    {
        ClientDto GetClient(Guid clientId);
        void SaveClient(SaveClientDto dto);
        IEnumerable<ClientDto> GetClients(string clientNameQuery, Guid customerId);
    }
}