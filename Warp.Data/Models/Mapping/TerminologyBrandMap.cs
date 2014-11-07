using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TerminologyBrandMap : EntityTypeConfiguration<TerminologyBrand>
    {
        public TerminologyBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.TerminologyBrandID);

            // Properties
            this.Property(t => t.TerminologyBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BrandTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TerminologyBrand");
            this.Property(t => t.TerminologyBrandID).HasColumnName("TerminologyBrandID");
            this.Property(t => t.TerminologyID).HasColumnName("TerminologyID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.BrandTerm).HasColumnName("BrandTerm");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.TerminologyID);

        }
    }
}
