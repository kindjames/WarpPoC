using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;

namespace Warp.Data.Entities
{
    public class ContactAddress : EntityBase
    {
        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Address4 { get; set; }

        public string Address5 { get; set; }

        [Required]
        public string Postcode { get; set; }

        public int? GeographicPostcodeId { get; set; }
    }
}