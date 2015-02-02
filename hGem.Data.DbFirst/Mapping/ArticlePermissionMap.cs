using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ArticlePermissionMap : EntityTypeConfiguration<ArticlePermission>
    {
        public ArticlePermissionMap()
        {
            // Primary Key
            HasKey(t => t.ArticlePermissionId);

            // Properties
            // Table & Column Mappings
            ToTable("ArticlePermission", "Help");
            Property(t => t.ArticlePermissionId).HasColumnName("ArticlePermissionID");
            Property(t => t.ArticleId).HasColumnName("ArticleID");
            Property(t => t.PermissionId).HasColumnName("PermissionID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Permission)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.PermissionId);
            HasRequired(t => t.Article)
                .WithMany(t => t.ArticlePermissions)
                .HasForeignKey(d => d.ArticleId);

        }
    }
}
