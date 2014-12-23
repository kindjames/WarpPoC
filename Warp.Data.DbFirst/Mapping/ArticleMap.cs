using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            HasKey(t => t.ArticleId);

            // Properties
            Property(t => t.ArticleTitle)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("Article", "Help");
            Property(t => t.ArticleId).HasColumnName("ArticleID");
            Property(t => t.ArticleText).HasColumnName("ArticleText");
            Property(t => t.ArticleTitle).HasColumnName("ArticleTitle");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.IsPublished).HasColumnName("IsPublished");
            Property(t => t.DatePublished).HasColumnName("DatePublished");
        }
    }
}
