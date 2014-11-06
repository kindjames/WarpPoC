using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ApplicationLanguage
    {
        public int ApplicationLanguageId { get; set; }
        public string DisplayName { get; set; }
        public string LanguageCode { get; set; }
        public string FriendlyName { get; set; }
    }
}
