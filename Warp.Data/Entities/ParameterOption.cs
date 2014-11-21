using System;

namespace Warp.Data.Entities
{
    public class ParameterOption
    {
        public int ParameterOptionId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}