using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Brand", "Client");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.BrandStatusId).HasColumnName("BrandStatusID");
            this.Property(t => t.IndustrySectorId).HasColumnName("IndustrySectorID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.BrandStatus)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.BrandStatusId);
            this.HasRequired(t => t.Client)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.IndustrySector)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.IndustrySectorId);

        }
    }
}
