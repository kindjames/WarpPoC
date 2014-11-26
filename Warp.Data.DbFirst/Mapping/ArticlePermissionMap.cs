using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ArticlePermissionMap : EntityTypeConfiguration<ArticlePermission>
    {
        public ArticlePermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.ArticlePermissionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ArticlePermission", "Help");
            this.Property(t => t.ArticlePermissionId).HasColumnName("ArticlePermissionID");
            this.Property(t => t.ArticleId).HasColumnName("ArticleID");
            this.Property(t => t.PermissionId).HasColumnName("PermissionID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.PermissionId);
            this.HasRequired(t => t.Article)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.ArticleId);

        }
    }
}
