using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ForumAdminReplyMap : EntityTypeConfiguration<ForumAdminReply>
    {
        public ForumAdminReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumAdminReply1);

            // Properties
            this.Property(t => t.ForumAdminReply1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReplyText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ForumAdminReply");
            this.Property(t => t.ForumAdminReply1).HasColumnName("ForumAdminReply");
            this.Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.ReplyText).HasColumnName("ReplyText");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ForumThread)
                .WithMany(t => t.ForumAdminReplies)
                .HasForeignKey(d => d.ForumThreadId);

        }
    }
}
