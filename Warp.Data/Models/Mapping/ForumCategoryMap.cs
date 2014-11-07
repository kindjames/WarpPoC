using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ForumCategoryMap : EntityTypeConfiguration<ForumCategory>
    {
        public ForumCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumCategoryID);

            // Properties
            this.Property(t => t.ForumCategoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("ForumCategory");
            this.Property(t => t.ForumCategoryID).HasColumnName("ForumCategoryID");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.Locked).HasColumnName("Locked");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
