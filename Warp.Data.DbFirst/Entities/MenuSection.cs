using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class MenuSection
    {
        public MenuSection()
        {
            MenuConfigs = new List<MenuConfig>();
            MenuSectionPossibleAnswers = new List<MenuSectionPossibleAnswer>();
        }

        public int MenuSectionId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
        public virtual ICollection<MenuSectionPossibleAnswer> MenuSectionPossibleAnswers { get; set; }
    }
}