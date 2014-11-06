using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientLogo
    {
        public int ClientLogoID { get; set; }
        public int ClientID { get; set; }
        public string LogoPath { get; set; }
    }
}
