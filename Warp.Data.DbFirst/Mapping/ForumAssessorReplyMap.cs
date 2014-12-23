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
            HasKey(t => t.ForumAssessorReplyId);

            // Properties
            Property(t => t.ForumAssessorReplyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReplyText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("ForumAssessorReply");
            Property(t => t.ForumAssessorReplyId).HasColumnName("ForumAssessorReplyID");
            Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.ReplyText).HasColumnName("ReplyText");
            Property(t => t.Display).HasColumnName("Display");
            Property(t => t.Reported).HasColumnName("Reported");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.ForumThread)
                .WithMany(t => t.ForumAssessorReplies)
                .HasForeignKey(d => d.ForumThreadId);

        }
    }
}
