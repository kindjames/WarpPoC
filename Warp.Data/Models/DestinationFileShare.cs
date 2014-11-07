using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class DestinationFileShare
    {
        public int DestinationFileShareId { get; set; }
        public int DestinationId { get; set; }
        public int FilepathLocationId { get; set; }
        public string CustomFilePath { get; set; }
        public string SpecificFolder { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
