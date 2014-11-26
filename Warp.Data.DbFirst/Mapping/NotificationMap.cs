using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(160);

            this.Property(t => t.HyperlinkURL)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.HyperlinkText)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.DisplayOnActionMessage)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Notification");
            this.Property(t => t.NotificationId).HasColumnName("NotificationID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.NotificationCategoryId).HasColumnName("NotificationCategoryID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.HyperlinkURL).HasColumnName("HyperlinkURL");
            this.Property(t => t.HyperlinkText).HasColumnName("HyperlinkText");
            this.Property(t => t.DisplayOnActionMessage).HasColumnName("DisplayOnActionMessage");
            this.Property(t => t.HasBeenRead).HasColumnName("HasBeenRead");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.Notifications)
                .HasForeignKey(d => d.UserRoleId);
            this.HasRequired(t => t.NotificationCategory)
                .WithMany(t => t.Notifications)
                .HasForeignKey(d => d.NotificationCategoryId);

        }
    }
}
