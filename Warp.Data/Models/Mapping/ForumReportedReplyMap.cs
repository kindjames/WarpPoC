using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ForumReportedReplyMap : EntityTypeConfiguration<ForumReportedReply>
    {
        public ForumReportedReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumReportedReplyID);

            // Properties
            this.Property(t => t.ForumReportedReplyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReportText)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumReportedReply");
            this.Property(t => t.ForumReportedReplyID).HasColumnName("ForumReportedReplyID");
            this.Property(t => t.ForumAssessorReplyID).HasColumnName("ForumAssessorReplyID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.ReportText).HasColumnName("ReportText");
            this.Property(t => t.ReportAdded).HasColumnName("ReportAdded");
            this.Property(t => t.CheckedByAdminID).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Reviewed).HasColumnName("Reviewed");
            this.Property(t => t.Remove).HasColumnName("Remove");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.ForumAssessorReply)
                .WithMany(t => t.ForumReportedReplies)
                .HasForeignKey(d => d.ForumAssessorReplyID);

        }
    }
}
