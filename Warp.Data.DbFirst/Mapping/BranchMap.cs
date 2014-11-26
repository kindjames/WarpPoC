using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            // Primary Key
            this.HasKey(t => t.BranchId);

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
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.BranchStatusId).HasColumnName("BranchStatusID");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.IndustrySectorId).HasColumnName("IndustrySectorID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
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
                .HasForeignKey(d => d.AreaId);

            this.HasRequired(t => t.BranchStatus)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BranchStatusId);

            this.HasRequired(t => t.Brand)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BrandId);

            this.HasRequired(t => t.Currency)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.CurrencyId);

            this.HasOptional(t => t.Person)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.PersonId);
        }
    }
}
