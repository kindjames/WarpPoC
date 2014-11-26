using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ForumAssessorReplyMap : EntityTypeConfiguration<ForumAssessorReply>
    {
        public ForumAssessorReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumAssessorReplyId);

            // Properties
            this.Property(t => t.ForumAssessorReplyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReplyText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumAssessorReply");
            this.Property(t => t.ForumAssessorReplyId).HasColumnName("ForumAssessorReplyID");
            this.Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.ReplyText).HasColumnName("ReplyText");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.Reported).HasColumnName("Reported");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.ForumThread)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.ForumThreadId);

        }
    }
}
