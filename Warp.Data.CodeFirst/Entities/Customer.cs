using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class Customer : EntityBase
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UrlName { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string CustomerCode { get; set; }

        [Required]
        public int DefaultLanguageId { get; set; }
    }
}