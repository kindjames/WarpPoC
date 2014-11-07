using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AreaLegacyUserMap : EntityTypeConfiguration<AreaLegacyUser>
    {
        public AreaLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaLegacyID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AreaLegacyUser", "Migration");
            this.Property(t => t.AreaLegacyID).HasColumnName("AreaLegacyID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.LegacyID).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.AreaLegacyUsers)
                .HasForeignKey(d => d.AreaID);

        }
    }
}
