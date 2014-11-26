using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NotificationCategoryMap : EntityTypeConfiguration<NotificationCategory>
    {
        public NotificationCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationCategoryId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("NotificationCategory");
            this.Property(t => t.NotificationCategoryId).HasColumnName("NotificationCategoryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}