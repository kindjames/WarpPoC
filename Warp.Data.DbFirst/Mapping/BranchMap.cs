using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            // Primary Key
            HasKey(t => t.BranchId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Code)
                .HasMaxLength(10);

            Property(t => t.Website)
                .HasMaxLength(100);

            Property(t => t.Telephone)
                .HasMaxLength(100);

            Property(t => t.Fax)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Branch", "Client");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.BranchStatusId).HasColumnName("BranchStatusID");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.IndustrySectorId).HasColumnName("IndustrySectorID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.Website).HasColumnName("Website");
            Property(t => t.Telephone).HasColumnName("Telephone");
            Property(t => t.Fax).HasColumnName("Fax");

            // Relationships
            HasRequired(t => t.Area)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.AreaId);

            HasRequired(t => t.BranchStatus)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BranchStatusId);

            HasRequired(t => t.Brand)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.BrandId);

            HasRequired(t => t.Currency)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.CurrencyId);

            HasOptional(t => t.Person)
                .WithMany(t => t.Branches)
                .HasForeignKey(d => d.PersonId);
        }
    }
}
