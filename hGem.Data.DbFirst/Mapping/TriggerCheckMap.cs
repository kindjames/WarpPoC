using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerCheckMap : EntityTypeConfiguration<TriggerCheck>
    {
        public TriggerCheckMap()
        {
            // Primary Key
            HasKey(t => t.TriggerCheckId);

            // Properties
            // Table & Column Mappings
            ToTable("TriggerCheck", "Subscriptions");
            Property(t => t.TriggerCheckId).HasColumnName("TriggerCheckId");
            Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            Property(t => t.DateChecked).HasColumnName("DateChecked");
            Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            Property(t => t.Processed).HasColumnName("Processed");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            HasRequired(t => t.Subscription)
                .WithMany(t => t.TriggerChecks)
                .HasForeignKey(d => d.SubscriptionId);
            HasOptional(t => t.TriggerInstance)
                .WithMany(t => t.TriggerChecks)
                .HasForeignKey(d => d.TriggerInstanceId);

        }
    }
}
