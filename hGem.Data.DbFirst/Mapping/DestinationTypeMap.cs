using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DestinationTypeMap : EntityTypeConfiguration<DestinationType>
    {
        public DestinationTypeMap()
        {
            // Primary Key
            HasKey(t => t.DestinationTypeId);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(75);

            // Table & Column Mappings
            ToTable("DestinationType", "Subscriptions");
            Property(t => t.DestinationTypeId).HasColumnName("DestinationTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
