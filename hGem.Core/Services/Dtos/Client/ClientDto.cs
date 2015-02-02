using System;
using hGem.Core.Domain.Enum;
using hGem.Core.Services.Dtos.Users;

namespace hGem.Core.Services.Dtos.Client
{
    public class ClientDto : DtoBase
    {
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public string Code { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? DateValidFrom { get; set; }
        public UserDto AccountManager { get; set; }
    }
}