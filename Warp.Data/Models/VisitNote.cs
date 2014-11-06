using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitNote
    {
        public int VisitNoteID { get; set; }
        public int VisitID { get; set; }
        public int NoteID { get; set; }
        public virtual Note Note { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
