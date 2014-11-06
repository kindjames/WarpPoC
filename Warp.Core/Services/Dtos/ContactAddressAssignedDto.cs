using System;

namespace Warp.Core.Services.Dtos
{
    public class ContactAddressAssignedDto
    {
        // Assignment
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }

        // Admin assigned Id
        public int AssignedByAdminId { get; set; }
        public string AssignedByAdminName { get; set; }
        
        // Address Type
        public int ContactAddressTypeId { get; set; }
        public string ContactAddressTypeName { get; set; }

        // Address data
        public int ContactAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public int GeographicPostcodeId { get; set; }
    }
}