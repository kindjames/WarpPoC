using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffMemberFeatureMap : EntityTypeConfiguration<StaffMemberFeature>
    {
        public StaffMemberFeatureMap()
        {
            // Primary Key
            HasKey(t => t.StaffMemberFeatureId);

            // Properties
            Property(t => t.StaffMemberFeatureId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("StaffMemberFeature");
            Property(t => t.StaffMemberFeatureId).HasColumnName("StaffMemberFeatureID");
            Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            Property(t => t.StaffFeatureId).HasColumnName("StaffFeatureID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.StaffFeature)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffFeatureId);
            HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberFeatures)
                .HasForeignKey(d => d.StaffMemberId);

        }
    }
}
