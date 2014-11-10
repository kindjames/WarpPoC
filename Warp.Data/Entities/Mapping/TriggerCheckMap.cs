using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class TriggerCheckMap : EntityTypeConfiguration<TriggerCheck>
    {
        public TriggerCheckMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerCheckId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TriggerCheck", "Subscriptions");
            this.Property(t => t.TriggerCheckId).HasColumnName("TriggerCheckId");
            this.Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            this.Property(t => t.DateChecked).HasColumnName("DateChecked");
            this.Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.Subscription)
                .WithMany(t => t.TriggerChecks)
                .HasForeignKey(d => d.SubscriptionId);
            this.HasOptional(t => t.TriggerInstance)
                .WithMany(t => t.TriggerChecks)
                .HasForeignKey(d => d.TriggerInstanceId);

        }
    }
}
