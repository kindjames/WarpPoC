using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class NotificationCategoryMap : EntityTypeConfiguration<NotificationCategory>
    {
        public NotificationCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationCategoryID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("NotificationCategory");
            this.Property(t => t.NotificationCategoryID).HasColumnName("NotificationCategoryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
