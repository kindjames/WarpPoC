using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Data.Entities
{
    public enum RoleEnum
    {
        [Description("Access all")]
        GodMode,
        [Description("Other mode role")]
        OtherMode,
    }
}
