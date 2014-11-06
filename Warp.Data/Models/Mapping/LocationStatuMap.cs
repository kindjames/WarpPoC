using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class LocationStatuMap : EntityTypeConfiguration<LocationStatu>
    {
        public LocationStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.LocationStatusID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LocationStatus", "Client");
            this.Property(t => t.LocationStatusID).HasColumnName("LocationStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
