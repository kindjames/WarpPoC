using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuConfigBranchMap : EntityTypeConfiguration<MenuConfigBranch>
    {
        public MenuConfigBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigBranchId);

            // Properties
            this.Property(t => t.MenuConfigBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigBranch");
            this.Property(t => t.MenuConfigBranchId).HasColumnName("MenuConfigBranchID");
            this.Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBranches)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
