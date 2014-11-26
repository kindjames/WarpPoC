using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AdminClientContactTrackingMap : EntityTypeConfiguration<AdminClientContactTracking>
    {
        public AdminClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.AdminClientContactTrackingId);

            // Properties
            this.Property(t => t.AdminClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AdminClientContactTracking");
            this.Property(t => t.AdminClientContactTrackingId).HasColumnName("AdminClientContactTrackingID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.AdminClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
