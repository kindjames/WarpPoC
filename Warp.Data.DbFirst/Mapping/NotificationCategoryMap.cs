using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NotificationCategoryMap : EntityTypeConfiguration<NotificationCategory>
    {
        public NotificationCategoryMap()
        {
            // Primary Key
            HasKey(t => t.NotificationCategoryId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            ToTable("NotificationCategory");
            Property(t => t.NotificationCategoryId).HasColumnName("NotificationCategoryID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
