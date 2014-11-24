using System;

namespace Warp.Data.Entities
{
    public class MenuItemPossibleAnswer
    {
        public int MenuItemPossibleAnswerId { get; set; }
        public int MenuItemId { get; set; }
        public int PossibleAnswerId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}