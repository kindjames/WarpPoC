using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PageTourMap : EntityTypeConfiguration<PageTour>
    {
        public PageTourMap()
        {
            // Primary Key
            this.HasKey(t => t.PageTourID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PageTour", "Help");
            this.Property(t => t.PageTourID).HasColumnName("PageTourID");
            this.Property(t => t.PageID).HasColumnName("PageID");
            this.Property(t => t.TourID).HasColumnName("TourID");

            // Relationships
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.TourID);
            this.HasRequired(t => t.Page)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.PageID);

        }
    }
}
