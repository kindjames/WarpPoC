using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SuggestionStatu
    {
        public SuggestionStatu()
        {
            this.Suggestions = new List<Suggestion>();
        }

        public byte SuggestionStatusID { get; set; }
        public string Title { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
    }
}
