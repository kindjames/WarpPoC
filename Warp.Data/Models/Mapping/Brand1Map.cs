using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class Brand1Map : EntityTypeConfiguration<Brand1>
    {
        public Brand1Map()
        {
            // Primary Key
            this.HasKey(t => t.BrandID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Brand");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.BrandStatusID).HasColumnName("BrandStatusID");
            this.Property(t => t.IndustrySectorID).HasColumnName("IndustrySectorID");
            this.Property(t => t.AccountManagerAdminID).HasColumnName("AccountManagerAdminID");
            this.Property(t => t.AssessorBanDays).HasColumnName("AssessorBanDays");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.BrandStatus1)
                .WithMany(t => t.Brand1)
                .HasForeignKey(d => d.BrandStatusID);
            this.HasRequired(t => t.Client1)
                .WithMany(t => t.Brand1)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
