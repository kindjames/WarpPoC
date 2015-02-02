using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionDestinationMap : EntityTypeConfiguration<SubscriptionDestination>
    {
        public SubscriptionDestinationMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionDestinationId);

            // Properties
            // Table & Column Mappings
            ToTable("SubscriptionDestination", "Subscriptions");
            Property(t => t.SubscriptionDestinationId).HasColumnName("SubscriptionDestinationId");
            Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Destination)
                .WithMany(t => t.SubscriptionDestinations)
                .HasForeignKey(d => d.DestinationId);
            HasOptional(t => t.Subscription)
                .WithMany(t => t.SubscriptionDestinations)
                .HasForeignKey(d => d.SubscriptionId);

        }
    }
}
