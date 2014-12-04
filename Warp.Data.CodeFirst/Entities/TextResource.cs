using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class TextResource : EntityBase
    {
        public int TextResourceId { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public virtual Client Client { get; set; }

        public virtual Language Language { get; set; }

        public virtual TextResourceIdentifier TextResourceIdentifier { get; set; }
    }
}