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
            HasKey(t => t.AdminClientContactTrackingId);

            // Properties
            Property(t => t.AdminClientContactTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AdminClientContactTracking");
            Property(t => t.AdminClientContactTrackingId).HasColumnName("AdminClientContactTrackingID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.ClientContactTrackingId).HasColumnName("ClientContactTrackingID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.AdminClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingId);

        }
    }
}
