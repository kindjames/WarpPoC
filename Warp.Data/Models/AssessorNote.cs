using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorNote
    {
        public int AssessorNoteID { get; set; }
        public int AssessorID { get; set; }
        public int NoteID { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Note Note { get; set; }
    }
}
