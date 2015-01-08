using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Core.Services.Dtos.TextResources
{
    public class ValidateTextResourceDto
    {
        public bool IsResourceCodeValidated { get; set; }
        public bool IsResourceStringValidated { get; set; }
    }
}
