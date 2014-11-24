using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ForumReportedReplyMap : EntityTypeConfiguration<ForumReportedReply>
    {
        public ForumReportedReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumReportedReplyId);

            // Properties
            this.Property(t => t.ForumReportedReplyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReportText)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumReportedReply");
            this.Property(t => t.ForumReportedReplyId).HasColumnName("ForumReportedReplyID");
            this.Property(t => t.ForumAssessorReplyId).HasColumnName("ForumAssessorReplyID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.ReportText).HasColumnName("ReportText");
            this.Property(t => t.DateReportAdded).HasColumnName("DateReportAdded");
            this.Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Reviewed).HasColumnName("Reviewed");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Remove).HasColumnName("Remove");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.ForumAssessorReply)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.ForumAssessorReplyId);

        }
    }
}
