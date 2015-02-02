using System;
using System.Collections.Generic;
using hGem.Core.Domain.Enum;

namespace hGem.Core.Services.Dtos.Client
{
    public class SaveClientDto : DtoBase
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public ClientStatus Status { get; set; }
        public Guid AccountManagerId { get; set; }
        public string Code { get; set; }

        public string InternalUseOnly { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string TripAdvisor { get; set; }

        public IEnumerable<ContactAddressAssignedDto> ContactAddresses { get; set; }

        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public string Note { get; set; }
    }
}