using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ForumAdminReplyMap : EntityTypeConfiguration<ForumAdminReply>
    {
        public ForumAdminReplyMap()
        {
            // Primary Key
            HasKey(t => t.ForumAdminReply1);

            // Properties
            Property(t => t.ForumAdminReply1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReplyText)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("ForumAdminReply");
            Property(t => t.ForumAdminReply1).HasColumnName("ForumAdminReply");
            Property(t => t.ForumThreadId).HasColumnName("ForumThreadID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.ReplyText).HasColumnName("ReplyText");
            Property(t => t.Display).HasColumnName("Display");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ForumThread)
                .WithMany(t => t.ForumAdminReplies)
                .HasForeignKey(d => d.ForumThreadId);

        }
    }
}
