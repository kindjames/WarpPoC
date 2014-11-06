using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuConfigBranchMap : EntityTypeConfiguration<MenuConfigBranch>
    {
        public MenuConfigBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigBranchID);

            // Properties
            this.Property(t => t.MenuConfigBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigBranch");
            this.Property(t => t.MenuConfigBranchID).HasColumnName("MenuConfigBranchID");
            this.Property(t => t.MenuConfigID).HasColumnName("MenuConfigID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Permission).HasColumnName("Permission");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.MenuConfigBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBranches)
                .HasForeignKey(d => d.MenuConfigID);

        }
    }
}
