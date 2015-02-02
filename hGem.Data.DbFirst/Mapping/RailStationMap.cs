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
            HasKey(t => t.RailStationId);

            // Properties
            Property(t => t.RailStationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("RailStation");
            Property(t => t.RailStationId).HasColumnName("RailStationID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Underground).HasColumnName("Underground");
            Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.RailStations)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
