using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PageArticleMap : EntityTypeConfiguration<PageArticle>
    {
        public PageArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.PageArticleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PageArticle", "Help");
            this.Property(t => t.PageArticleId).HasColumnName("PageArticleID");
            this.Property(t => t.PageId).HasColumnName("PageID");
            this.Property(t => t.ArticleId).HasColumnName("ArticleID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Article)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.ArticleId);
            this.HasRequired(t => t.Page)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.PageId);

        }
    }
}
