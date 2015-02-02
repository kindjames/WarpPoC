using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PageArticleMap : EntityTypeConfiguration<PageArticle>
    {
        public PageArticleMap()
        {
            // Primary Key
            HasKey(t => t.PageArticleId);

            // Properties
            // Table & Column Mappings
            ToTable("PageArticle", "Help");
            Property(t => t.PageArticleId).HasColumnName("PageArticleID");
            Property(t => t.PageId).HasColumnName("PageID");
            Property(t => t.ArticleId).HasColumnName("ArticleID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Article)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.ArticleId);
            HasRequired(t => t.Page)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.PageId);

        }
    }
}
