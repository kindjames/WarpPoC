using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class TextResourceIdentifier : EntityBase
    {
        [Required]
        public string ResourceIdentifierCode { get; set; }

        [DefaultValue(false)]
        public bool ClientOverridable { get; set; }

        public virtual IEnumerable<TextResource> TextResources { get; set; }

        #region CTORs
        
        /// <summary>
        /// Default CTOR
        /// </summary>
        public TextResourceIdentifier() { }

        /// <summary>
        /// Overridable Ctor for test purposes.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="resourceIdentifierCode"></param>
        /// <param name="clientOverridable"></param>
        public TextResourceIdentifier(Guid id, string resourceIdentifierCode, bool clientOverridable)
        {
            Id = id;
            ResourceIdentifierCode = resourceIdentifierCode;
            ClientOverridable = ClientOverridable;
        }
        
        #endregion CTORs
    }
}