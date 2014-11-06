using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class Branch1Map : EntityTypeConfiguration<Branch1>
    {
        public Branch1Map()
        {
            // Primary Key
            this.HasKey(t => t.BranchID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AssessorDisplayName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Branch");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AccountingClientID).HasColumnName("AccountingClientID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.BranchStatusID).HasColumnName("BranchStatusID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.AccountManagerAdminID).HasColumnName("AccountManagerAdminID");
            this.Property(t => t.AssessorBanDays).HasColumnName("AssessorBanDays");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.AssessorDisplayName).HasColumnName("AssessorDisplayName");
            this.Property(t => t.MobileApp).HasColumnName("MobileApp");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingClient)
                .WithMany(t => t.Branch1)
                .HasForeignKey(d => d.AccountingClientID);
            this.HasRequired(t => t.Area1)
                .WithMany(t => t.Branch1)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.BranchStatus1)
                .WithMany(t => t.Branch1)
                .HasForeignKey(d => d.BranchStatusID);
            this.HasRequired(t => t.Brand1)
                .WithMany(t => t.Branch1)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
