using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ForumReportedReplyMap : EntityTypeConfiguration<ForumReportedReply>
    {
        public ForumReportedReplyMap()
        {
            // Primary Key
            HasKey(t => t.ForumReportedReplyId);

            // Properties
            Property(t => t.ForumReportedReplyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReportText)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("ForumReportedReply");
            Property(t => t.ForumReportedReplyId).HasColumnName("ForumReportedReplyID");
            Property(t => t.ForumAssessorReplyId).HasColumnName("ForumAssessorReplyID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.ReportText).HasColumnName("ReportText");
            Property(t => t.DateReportAdded).HasColumnName("DateReportAdded");
            Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            Property(t => t.Reviewed).HasColumnName("Reviewed");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Remove).HasColumnName("Remove");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.ForumAssessorReply)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.ForumAssessorReplyId);

        }
    }
}
