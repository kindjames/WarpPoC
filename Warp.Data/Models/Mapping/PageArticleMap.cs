using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PageArticleMap : EntityTypeConfiguration<PageArticle>
    {
        public PageArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.PageArticleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PageArticle", "Help");
            this.Property(t => t.PageArticleID).HasColumnName("PageArticleID");
            this.Property(t => t.PageID).HasColumnName("PageID");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");

            // Relationships
            this.HasRequired(t => t.Article)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.ArticleID);
            this.HasRequired(t => t.Page)
                .WithMany(t => t.PageArticles)
                .HasForeignKey(d => d.PageID);

        }
    }
}
