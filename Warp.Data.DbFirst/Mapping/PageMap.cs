using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PageMap : EntityTypeConfiguration<Page>
    {
        public PageMap()
        {
            // Primary Key
            this.HasKey(t => t.PageId);

            // Properties
            this.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Page", "Help");
            this.Property(t => t.PageId).HasColumnName("PageID");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
