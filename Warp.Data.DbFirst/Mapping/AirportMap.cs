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
            this.HasKey(t => t.AirportId);

            // Properties
            this.Property(t => t.AirportId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AirportCode)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Airport");
            this.Property(t => t.AirportId).HasColumnName("AirportID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AirportCode).HasColumnName("AirportCode");
            this.Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.XCoordinate).HasColumnName("XCoordinate");
            this.Property(t => t.YCoordinate).HasColumnName("YCoordinate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.Airports)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
