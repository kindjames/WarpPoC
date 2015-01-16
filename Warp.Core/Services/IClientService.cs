using System;
using System.Collections.Generic;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Services
{
    public interface IClientService
    {
        IResponse<ClientDto> GetClient(Guid clientId);
        IResponse SaveClient(SaveClientDto dto);
        IResponse<IEnumerable<ClientDto>> GetClients(string clientNameQuery, Guid customerId);
    }
}