using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            HasKey(t => t.BrandId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Brand", "Client");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.BrandStatusId).HasColumnName("BrandStatusID");
            Property(t => t.IndustrySectorId).HasColumnName("IndustrySectorID");
            Property(t => t.Visible).HasColumnName("Visible");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.BrandStatus)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.BrandStatusId);
            HasRequired(t => t.Client)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.IndustrySector)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.IndustrySectorId);

        }
    }
}
