using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PageTourMap : EntityTypeConfiguration<PageTour>
    {
        public PageTourMap()
        {
            // Primary Key
            HasKey(t => t.PageTourId);

            // Properties
            // Table & Column Mappings
            ToTable("PageTour", "Help");
            Property(t => t.PageTourId).HasColumnName("PageTourID");
            Property(t => t.PageId).HasColumnName("PageID");
            Property(t => t.TourId).HasColumnName("TourID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Page)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.PageId);
            HasRequired(t => t.Tour)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.TourId);

        }
    }
}
