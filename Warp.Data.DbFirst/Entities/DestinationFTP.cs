using System;

namespace Warp.Data.DbFirst.Entities
{
    public class DestinationFTP
    {
        public int DestinationFTPId { get; set; }
        public int DestinationId { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Destination Destination { get; set; }
    }
}