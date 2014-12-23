using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionMap : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            Property(t => t.Description)
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("Subscription", "Subscriptions");
            Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.StartDate).HasColumnName("StartDate");
            Property(t => t.EndDate).HasColumnName("EndDate");
            Property(t => t.ClientId).HasColumnName("ClientId");
            Property(t => t.Owner).HasColumnName("Owner");
            Property(t => t.TriggerId).HasColumnName("TriggerId");
            Property(t => t.SubscriptionStatusId).HasColumnName("SubscriptionStatusId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.SubscriptionStatus)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.SubscriptionStatusId);
            HasOptional(t => t.Trigger)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
