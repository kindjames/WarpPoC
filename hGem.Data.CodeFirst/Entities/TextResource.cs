using System;
using hGem.Core.Data;

namespace hGem.Data.Entities
{
    public class TextResource : EntityBase
    {
        public new Guid Id { get; set; } // 'new' for defining composite-primary-key.
        public Guid ClientId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid ResourceIdentifierId { get; set; }
        public string ResourceString { get; set; }

        public virtual Client Client { get; set; }
        public virtual Language Language { get; set; }
        public virtual TextResourceIdentifier TextResourceIdentifier { get; set; }

        public TextResource()
        {
            
        }
    }
}