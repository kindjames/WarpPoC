using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Data.Entities;

namespace Warp.Testing.Unit.Data.Data.TextResource
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
            return new TextResourceIdentifier {Id = };
        }
    }
}
