using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location", "Client");
            this.Property(t => t.LocationID).HasColumnName("LocationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LocationStatusID).HasColumnName("LocationStatusID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");

            // Relationships
            this.HasRequired(t => t.LocationStatu)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.LocationStatusID);

        }
    }
}
