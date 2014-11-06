using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AdminClientContactTrackingMap : EntityTypeConfiguration<AdminClientContactTracking>
    {
        public AdminClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.AdminClientContactTrackingID);

            // Properties
            this.Property(t => t.AdminClientContactTrackingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AdminClientContactTracking");
            this.Property(t => t.AdminClientContactTrackingID).HasColumnName("AdminClientContactTrackingID");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.ClientContactTrackingID).HasColumnName("ClientContactTrackingID");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.AdminClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingID);

        }
    }
}
