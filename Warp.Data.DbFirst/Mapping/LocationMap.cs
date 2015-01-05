using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            HasKey(t => t.LocationId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Location", "Client");
            Property(t => t.LocationId).HasColumnName("LocationID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.LocationStatusId).HasColumnName("LocationStatusID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.LocationStatus)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.LocationStatusId);

        }
    }
}
