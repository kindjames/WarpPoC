using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffMemberFeatureMap : EntityTypeConfiguration<StaffMemberFeature>
    {
        public StaffMemberFeatureMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffMemberFeatureId);

            // Properties
            this.Property(t => t.StaffMemberFeatureId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StaffMemberFeature");
            this.Property(t => t.StaffMemberFeatureId).HasColumnName("StaffMemberFeatureID");
            this.Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            this.Property(t => t.StaffFeatureId).HasColumnName("StaffFeatureID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.StaffFeature)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffFeatureId);
            this.HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffMemberId);

        }
    }
}
