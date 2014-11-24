using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location", "Client");
            this.Property(t => t.LocationId).HasColumnName("LocationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LocationStatusId).HasColumnName("LocationStatusID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.LocationStatus)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.LocationStatusId);

        }
    }
}
