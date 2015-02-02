using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Data.Entities.Tmp
{
    public class TextResource : EntityBase
    {
        public new int Id { get; set; } // 'new' for defining composite-primary-key.

        public int ClientId { get; set; }

        public int LanguageId { get; set; }

        public int ResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public virtual Client Client { get; set; }
        public virtual Language Language { get; set; }
        public virtual TextResourceIdentifier TextResourceIdentifier { get; set; }
    }
}
