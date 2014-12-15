using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class Language : EntityBase
    {
        public int LanguageId { get; set; }

        [Required]
        public string InvariantCulture { get; set; }

        [Required]
        public string Locale { get; set; }

        [Required]
        public string Name { get; set; }
    }
}