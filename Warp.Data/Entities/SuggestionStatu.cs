using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SuggestionStatu
    {
        public SuggestionStatu()
        {
            Suggestions = new List<Suggestion>();
        }

        public byte SuggestionStatusId { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
    }
}