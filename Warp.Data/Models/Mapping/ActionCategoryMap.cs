using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ActionCategoryMap : EntityTypeConfiguration<ActionCategory>
    {
        public ActionCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionCategoryID);

            // Properties
            this.Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ActionCategory", "Auditing");
            this.Property(t => t.ActionCategoryID).HasColumnName("ActionCategoryID");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
