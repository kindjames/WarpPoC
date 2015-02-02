using System;
using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;
using hGem.Data.Infrastructure.Validation;

namespace hGem.Data.Entities
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

        [NotEmptyGuid]
        public Guid DefaultLanguageId { get; set; }
    }
}