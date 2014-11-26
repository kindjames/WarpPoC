using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionDestinationMap : EntityTypeConfiguration<SubscriptionDestination>
    {
        public SubscriptionDestinationMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionDestinationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubscriptionDestination", "Subscriptions");
            this.Property(t => t.SubscriptionDestinationId).HasColumnName("SubscriptionDestinationId");
            this.Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Destination)
                .WithMany(t => t.SubscriptionDestinations)
                .HasForeignKey(d => d.DestinationId);
            this.HasOptional(t => t.Subscription)
                .WithMany(t => t.SubscriptionDestinations)
                .HasForeignKey(d => d.SubscriptionId);

        }
    }
}
