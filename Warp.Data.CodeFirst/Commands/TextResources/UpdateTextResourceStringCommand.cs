using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Commands.TextResources
{
    public sealed class UpdateTextResourceStringCommand : ICommand
    {
        public int Id { get; set; }

        [IdRequired]
        public int ResourceIdentifierId { get; set; }

        [Required]
        public string ResourceString { get; set; }
    }
}
