using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warp.Data.Entities
{
    public class TextResource : EntityBase
    {
        [Key, Column(Order = 0)]
        public int TextResourceId { get; set; }

        [Key, Column(Order = 1)]
        public int ClientId { get; set; }

        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }

        [Key, Column(Order = 3)]
        public int TextResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public virtual Client Client { get; set; }
        public virtual Language Language { get; set; }
        public virtual TextResourceIdentifier TextResourceIdentifier { get; set; }
    }
}