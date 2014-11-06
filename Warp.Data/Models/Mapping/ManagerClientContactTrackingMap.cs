using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerClientContactTrackingMap : EntityTypeConfiguration<ManagerClientContactTracking>
    {
        public ManagerClientContactTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerClientContactTrackingID);

            // Properties
            this.Property(t => t.ManagerClientContactTrackingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ManagerClientContactTracking");
            this.Property(t => t.ManagerClientContactTrackingID).HasColumnName("ManagerClientContactTrackingID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.ClientContactTrackingID).HasColumnName("ClientContactTrackingID");

            // Relationships
            this.HasRequired(t => t.ClientContactTracking)
                .WithMany(t => t.ManagerClientContactTrackings)
                .HasForeignKey(d => d.ClientContactTrackingID);

        }
    }
}
