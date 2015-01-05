using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ForumCategoryMap : EntityTypeConfiguration<ForumCategory>
    {
        public ForumCategoryMap()
        {
            // Primary Key
            HasKey(t => t.ForumCategoryId);

            // Properties
            Property(t => t.ForumCategoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("ForumCategory");
            Property(t => t.ForumCategoryId).HasColumnName("ForumCategoryID");
            Property(t => t.CategoryName).HasColumnName("CategoryName");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.Locked).HasColumnName("Locked");
            Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
