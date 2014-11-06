using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionStatuMap : EntityTypeConfiguration<RegionStatu>
    {
        public RegionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionStatusID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RegionStatus", "Client");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
