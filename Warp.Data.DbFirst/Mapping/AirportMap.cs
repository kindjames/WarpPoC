using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AirportMap : EntityTypeConfiguration<Airport>
    {
        public AirportMap()
        {
            // Primary Key
            HasKey(t => t.AirportId);

            // Properties
            Property(t => t.AirportId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.AirportCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Airport");
            Property(t => t.AirportId).HasColumnName("AirportID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.AirportCode).HasColumnName("AirportCode");
            Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.Airports)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
