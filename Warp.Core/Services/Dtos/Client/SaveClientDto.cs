using System;
using System.Collections.Generic;

namespace Warp.Core.Services.Dtos.Client
{
    public class SaveClientDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public short StatusId { get; set; }
        public int AccountManagerId { get; set; }
        public string Code { get; set; }
        public int LegacyId { get; set; }
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