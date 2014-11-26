using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PageTourMap : EntityTypeConfiguration<PageTour>
    {
        public PageTourMap()
        {
            // Primary Key
            this.HasKey(t => t.PageTourId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PageTour", "Help");
            this.Property(t => t.PageTourId).HasColumnName("PageTourID");
            this.Property(t => t.PageId).HasColumnName("PageID");
            this.Property(t => t.TourId).HasColumnName("TourID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Page)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.PageId);
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.TourId);

        }
    }
}
