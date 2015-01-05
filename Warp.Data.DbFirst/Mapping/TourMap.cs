using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TourMap : EntityTypeConfiguration<Tour>
    {
        public TourMap()
        {
            // Primary Key
            HasKey(t => t.TourId);

            // Properties
            Property(t => t.TourName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Tour", "Help");
            Property(t => t.TourId).HasColumnName("TourID");
            Property(t => t.TourName).HasColumnName("TourName");
            Property(t => t.AlwaysShow).HasColumnName("AlwaysShow");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
