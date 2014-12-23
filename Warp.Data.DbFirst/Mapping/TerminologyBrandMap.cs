using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TerminologyBrandMap : EntityTypeConfiguration<TerminologyBrand>
    {
        public TerminologyBrandMap()
        {
            // Primary Key
            HasKey(t => t.TerminologyBrandId);

            // Properties
            Property(t => t.TerminologyBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.BrandTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TerminologyBrand");
            Property(t => t.TerminologyBrandId).HasColumnName("TerminologyBrandID");
            Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.BrandTerm).HasColumnName("BrandTerm");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyBrands)
                .HasForeignKey(d => d.TerminologyId);

        }
    }
}
