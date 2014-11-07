using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class IndustrySectorMap : EntityTypeConfiguration<IndustrySector>
    {
        public IndustrySectorMap()
        {
            // Primary Key
            this.HasKey(t => t.IndustrySectorID);

            // Properties
            this.Property(t => t.SectorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SectorNameForAssessor)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("IndustrySector", "Client");
            this.Property(t => t.IndustrySectorID).HasColumnName("IndustrySectorID");
            this.Property(t => t.SectorName).HasColumnName("SectorName");
            this.Property(t => t.SectorNameForAssessor).HasColumnName("SectorNameForAssessor");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.IndustrySector2)
                .WithOptional(t => t.IndustrySector1);

        }
    }
}
