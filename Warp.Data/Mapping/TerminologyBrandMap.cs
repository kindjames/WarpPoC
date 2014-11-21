using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TerminologyBrandMap : EntityTypeConfiguration<TerminologyBrand>
    {
        public TerminologyBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.TerminologyBrandId);

            // Properties
            this.Property(t => t.TerminologyBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BrandTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TerminologyBrand");
            this.Property(t => t.TerminologyBrandId).HasColumnName("TerminologyBrandID");
            this.Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.BrandTerm).HasColumnName("BrandTerm");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.TerminologyId);

        }
    }
}
