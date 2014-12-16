using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Services.Dtos.Users;
using Warp.WebUI.Models.Clients;
using Warp.WebUI.Models.Users;

namespace Warp.WebUI.Mappings.Clients
{
    public class ClientDtoToClientViewModelMapping : IMappingConfiguration<ClientDto, ClientViewModel>
    {
        private readonly IObjectMapper _objectMapper;

        public ClientDtoToClientViewModelMapping(IObjectMapper objectMapper)
        {
            _objectMapper = objectMapper;
        }

        public ClientViewModel Map(ClientDto source)
        {
            return new ClientViewModel
            {
                Id = source.ClientId,
                Code = source.Code,
                Name = source.Name,
                AccountManager = _objectMapper.Map<UserDto, UserViewModel>(source.AccountManager),
                Status = source.Status,
            };
        }
    }
}