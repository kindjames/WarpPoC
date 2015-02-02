using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class TextResource : EntityBase
    {
        [Key, Column(Order = 0)]
        public new Guid Id { get; set; } // 'new' for defining composite-primary-key.

        [Key, Column(Order = 1)]
        public Guid ClientId { get; set; }

        [Key, Column(Order = 2)]
        public Guid LanguageId { get; set; }

        [Key, Column(Order = 3)]
        public Guid TextResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public virtual Client Client { get; set; }
        public virtual Language Language { get; set; }
        public virtual TextResourceIdentifier TextResourceIdentifier { get; set; }
    }
}