using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Brand", "Client");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.BrandStatusID).HasColumnName("BrandStatusID");
            this.Property(t => t.IndustrySectorID).HasColumnName("IndustrySectorID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.BrandStatu)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.BrandStatusID);
            this.HasRequired(t => t.Client)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.IndustrySector)
                .WithMany(t => t.Brands)
                .HasForeignKey(d => d.IndustrySectorID);

        }
    }
}
