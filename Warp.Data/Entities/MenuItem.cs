using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class MenuItem
    {
        public MenuItem()
        {
            MenuConfigs = new List<MenuConfig>();
            MenuItemPossibleAnswers = new List<MenuItemPossibleAnswer>();
        }

        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
        public virtual ICollection<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
    }
}