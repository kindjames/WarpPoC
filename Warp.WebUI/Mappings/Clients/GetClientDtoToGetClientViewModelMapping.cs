using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.ViewModels.Clients;

namespace Warp.WebUI.Mappings.Clients
{
    public sealed class GetClientDtoToGetClientViewModelMapping : IMappingConfiguration<GetClientDto, GetClientViewModel>
    {
        public GetClientViewModel Map(GetClientDto source)
        {
            return new GetClientViewModel();
        }
    }
}