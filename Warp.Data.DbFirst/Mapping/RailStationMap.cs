using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RailStationMap : EntityTypeConfiguration<RailStation>
    {
        public RailStationMap()
        {
            // Primary Key
            this.HasKey(t => t.RailStationId);

            // Properties
            this.Property(t => t.RailStationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RailStation");
            this.Property(t => t.RailStationId).HasColumnName("RailStationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Underground).HasColumnName("Underground");
            this.Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            this.Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.RailStations)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
