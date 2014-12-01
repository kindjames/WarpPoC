using System;

namespace Warp.Data.DbFirst.Entities
{
    public class QuestionTracker
    {
        public int QuestionTrackerId { get; set; }
        public DateTime DateCreated { get; set; }
        public short AddedByAdminId { get; set; }
        public int MasterQuestionId { get; set; }
        public int? ClientId { get; set; }
        public int ChildQuestionId { get; set; }
        public DateTime? DateRemoved { get; set; }
        public short? RemovedByAdminId { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Question Question { get; set; }
        public virtual Question Question1 { get; set; }
    }
}