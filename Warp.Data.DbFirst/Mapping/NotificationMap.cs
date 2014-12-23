using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            // Primary Key
            HasKey(t => t.NotificationId);

            // Properties
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(160);

            Property(t => t.HyperlinkURL)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.HyperlinkText)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.DisplayOnActionMessage)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("Notification");
            Property(t => t.NotificationId).HasColumnName("NotificationID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.NotificationCategoryId).HasColumnName("NotificationCategoryID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Message).HasColumnName("Message");
            Property(t => t.HyperlinkURL).HasColumnName("HyperlinkURL");
            Property(t => t.HyperlinkText).HasColumnName("HyperlinkText");
            Property(t => t.DisplayOnActionMessage).HasColumnName("DisplayOnActionMessage");
            Property(t => t.HasBeenRead).HasColumnName("HasBeenRead");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.Notifications)
                .HasForeignKey(d => d.UserRoleId);
            HasRequired(t => t.NotificationCategory)
                .WithMany(t => t.Notifications)
                .HasForeignKey(d => d.NotificationCategoryId);

        }
    }
}
