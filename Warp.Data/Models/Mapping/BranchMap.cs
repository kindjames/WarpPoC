using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(10);

            this.Property(t => t.Website)
                .HasMaxLength(100);

            this.Property(t => t.Telephone)
                .HasMaxLength(100);

            this.Property(t => t.Fax)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Branch", "Client");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.BranchStatusID).HasColumnName("BranchStatusID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.IndustrySectorID).HasColumnName("IndustrySectorID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.Fax).HasColumnName("Fax");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.BranchStatu)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BranchStatusID);
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.CurrencyID);
            this.HasOptional(t => t.Person)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
