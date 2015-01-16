using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Core.Services.Dtos.TextResources
{
    public class ResourceStringDetailDto
    {
        public int TextResourceId { get; set; }
        public int ResourceIdentifierId { get; set; }
        public int LanguageId { get; set; }
        public int ClientId { get; set; }
        public string ResourceString { get; set; }
    }
}
