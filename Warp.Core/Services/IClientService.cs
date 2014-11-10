using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Services
{
    public interface IClientService
    {
        GetClientDto GetClient(int clientId);
        void SaveClient(SaveClientDto dto);
    }
}