using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class DestinationMap : EntityTypeConfiguration<Destination>
    {
        public DestinationMap()
        {
            // Primary Key
            this.HasKey(t => t.DestinationId);

            // Properties
            this.Property(t => t.FileName)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Destination", "Subscriptions");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.DestinationTypeId).HasColumnName("DestinationTypeId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.DestinationType)
                .WithMany(t => t.Destinations)
                .HasForeignKey(d => d.DestinationTypeId);

        }
    }
}
