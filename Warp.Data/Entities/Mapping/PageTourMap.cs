using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Page)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.PageID);
            this.HasRequired(t => t.Tour)
                .WithMany(t => t.PageTours)
                .HasForeignKey(d => d.TourID);

        }
    }
}
