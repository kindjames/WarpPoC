using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BrandStatus1Map : EntityTypeConfiguration<BrandStatus1>
    {
        public BrandStatus1Map()
        {
            // Primary Key
            this.HasKey(t => t.BrandStatusID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BrandStatus");
            this.Property(t => t.BrandStatusID).HasColumnName("BrandStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
