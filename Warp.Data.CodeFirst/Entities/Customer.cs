using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;

namespace Warp.Data.Entities
{
    public class Customer : EntityBase
    {
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