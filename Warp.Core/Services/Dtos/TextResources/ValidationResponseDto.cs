using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Core.Services.Dtos.TextResources
{
    public sealed class ValidationResponseDto
    {
        public IEnumerable<string> Messages { get; set; }
        public bool IsValidated { get; set; }

        public ValidationResponseDto()
        {
            IsValidated = false;
            Messages = new List<string>();
        }
    }
}
