using System;
using hGem.Data.Entities;

namespace hGem.Testing.Unit.Data.Data.TextResource
{
    public class TextResourceIdentifierBuilder
    {
        public Guid Id = new Guid();
        public string ResourceIdentifierCode;
        public bool ClientOverridable;

        //public TextResourceIdentifierBuilder(Guid id, string resourceIdentifierCode, bool clientOverridable)
        //{
        //    Id = id;
        //    ResourceIdentifierCode = resourceIdentifierCode;
        //    ClientOverridable = clientOverridable;
        //}

        public TextResourceIdentifier Build()
        {
            return new TextResourceIdentifier {Id = Guid.NewGuid()};
        }
    }
}
