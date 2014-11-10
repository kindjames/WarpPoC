using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBranches)
                .HasForeignKey(d => d.MenuConfigID);

        }
    }
}
