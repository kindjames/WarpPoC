using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TourMap : EntityTypeConfiguration<Tour>
    {
        public TourMap()
        {
            // Primary Key
            this.HasKey(t => t.TourID);

            // Properties
            this.Property(t => t.TourName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tour", "Help");
            this.Property(t => t.TourID).HasColumnName("TourID");
            this.Property(t => t.TourName).HasColumnName("TourName");
            this.Property(t => t.AlwaysShow).HasColumnName("AlwaysShow");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
