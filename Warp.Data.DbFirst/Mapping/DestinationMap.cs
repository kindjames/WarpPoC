using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationMap : EntityTypeConfiguration<Destination>
    {
        public DestinationMap()
        {
            // Primary Key
            HasKey(t => t.DestinationId);

            // Properties
            Property(t => t.FileName)
                .HasMaxLength(1000);

            // Table & Column Mappings
            ToTable("Destination", "Subscriptions");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.DestinationTypeId).HasColumnName("DestinationTypeId");
            Property(t => t.FileName).HasColumnName("FileName");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.DestinationType)
                .WithMany(t => t.Destinations)
                .HasForeignKey(d => d.DestinationTypeId);

        }
    }
}
