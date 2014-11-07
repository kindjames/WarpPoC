using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuSection
    {
        public MenuSection()
        {
            this.MenuConfigs = new List<MenuConfig>();
            this.MenuSectionPossibleAnswers = new List<MenuSectionPossibleAnswer>();
        }

        public int MenuSectionID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
        public virtual ICollection<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }
    }
}
