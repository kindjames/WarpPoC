using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandNote
    {
        public int BrandNoteID { get; set; }
        public int BrandID { get; set; }
        public int NoteID { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Note Note { get; set; }
    }
}
