using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuConfigBranchMap : EntityTypeConfiguration<MenuConfigBranch>
    {
        public MenuConfigBranchMap()
        {
            // Primary Key
            HasKey(t => t.MenuConfigBranchId);

            // Properties
            Property(t => t.MenuConfigBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuConfigBranch");
            Property(t => t.MenuConfigBranchId).HasColumnName("MenuConfigBranchID");
            Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBranches)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
