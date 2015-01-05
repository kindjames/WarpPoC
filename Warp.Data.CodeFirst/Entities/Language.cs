using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;

namespace Warp.Data.Entities
{
    public class Language : EntityBase
    {
        [Required]
        public string InvariantCulture { get; set; }

        [Required]
        public string Locale { get; set; }

        [Required]
        public string Name { get; set; }
    }
}