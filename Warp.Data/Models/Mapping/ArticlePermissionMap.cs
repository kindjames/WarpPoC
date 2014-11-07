using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ArticlePermissionMap : EntityTypeConfiguration<ArticlePermission>
    {
        public ArticlePermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticlePermissionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ArticlePermission", "Help");
            this.Property(t => t.ArticlePermissionID).HasColumnName("ArticlePermissionID");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.PermissionID);
            this.HasRequired(t => t.Article)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.ArticleID);

        }
    }
}
