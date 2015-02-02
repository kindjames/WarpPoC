using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Data.Entities.Tmp
{
    public class Language : EntityBase
    {
        [Required]
        public string InvariantCulture { get; set; }

        [Required]
        public string Locale { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
