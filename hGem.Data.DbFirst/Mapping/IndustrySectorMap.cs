using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class IndustrySectorMap : EntityTypeConfiguration<IndustrySector>
    {
        public IndustrySectorMap()
        {
            // Primary Key
            HasKey(t => t.IndustrySectorId);

            // Properties
            Property(t => t.SectorName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.SectorNameForAssessor)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("IndustrySector", "Client");
            Property(t => t.IndustrySectorId).HasColumnName("IndustrySectorID");
            Property(t => t.SectorName).HasColumnName("SectorName");
            Property(t => t.SectorNameForAssessor).HasColumnName("SectorNameForAssessor");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.IndustrySector2)
                .WithOptional(t => t.IndustrySector1);

        }
    }
}
