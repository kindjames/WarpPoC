using Warp.Core.Services.Dtos;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Services
{
    public interface IClientService
    {
        void SaveClient(SaveClientDto dto);
    }
}