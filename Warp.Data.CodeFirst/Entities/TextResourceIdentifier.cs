using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Data;

namespace Warp.Data.Entities
{
    public class TextResourceIdentifier : EntityBase
    {
        [Required]
        public string ResourceIdentifierCode { get; set; }

        [DefaultValue(false)]
        public bool ClientOverridable { get; set; }

        public virtual IEnumerable<TextResource> TextResources { get; set; }
    }
}