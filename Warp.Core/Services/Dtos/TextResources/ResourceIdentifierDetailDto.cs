using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Core.Services.Dtos.TextResources
{
    public class ResourceIdentifierDetailDto
    {
        public int ResourceIdentifierId { get; set; }
        public string ResourceIdentifierCode { get; set; }
        public bool ClientOverridable { get; set; }
    }
}
