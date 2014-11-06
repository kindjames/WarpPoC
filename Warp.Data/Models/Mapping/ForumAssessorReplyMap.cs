using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ForumAssessorReplyMap : EntityTypeConfiguration<ForumAssessorReply>
    {
        public ForumAssessorReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumAssessorReplyID);

            // Properties
            this.Property(t => t.ForumAssessorReplyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReplyText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumAssessorReply");
            this.Property(t => t.ForumAssessorReplyID).HasColumnName("ForumAssessorReplyID");
            this.Property(t => t.ForumThreadID).HasColumnName("ForumThreadID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.ReplyText).HasColumnName("ReplyText");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.Reported).HasColumnName("Reported");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.ForumThread)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.ForumThreadID);

        }
    }
}
