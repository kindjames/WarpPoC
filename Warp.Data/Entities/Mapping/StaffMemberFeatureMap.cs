using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class StaffMemberFeatureMap : EntityTypeConfiguration<StaffMemberFeature>
    {
        public StaffMemberFeatureMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffMemberFeatureID);

            // Properties
            this.Property(t => t.StaffMemberFeatureID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StaffMemberFeature");
            this.Property(t => t.StaffMemberFeatureID).HasColumnName("StaffMemberFeatureID");
            this.Property(t => t.StaffMemberID).HasColumnName("StaffMemberID");
            this.Property(t => t.StaffFeatureID).HasColumnName("StaffFeatureID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.StaffFeature)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffFeatureID);
            this.HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffMemberID);

        }
    }
}
