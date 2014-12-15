using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class TextResourceIdentifier : EntityBase
    {
        public int TextResourceIdentifierId { get; set; }

        [Required]
        public string TextResourceCode { get; set; }

        [DefaultValue(false)]
        public bool ClientOverridable { get; set; }

        public virtual IEnumerable<TextResource> TextResources { get; set; }
    }
}