using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class DestinationTypeMap : EntityTypeConfiguration<DestinationType>
    {
        public DestinationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DestinationTypeId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(75);

            // Table & Column Mappings
            this.ToTable("DestinationType", "Subscriptions");
            this.Property(t => t.DestinationTypeId).HasColumnName("DestinationTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
