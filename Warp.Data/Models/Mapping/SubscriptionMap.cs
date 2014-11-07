using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubscriptionMap : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.Description)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Subscription", "Subscriptions");
            this.Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.Owner).HasColumnName("Owner");
            this.Property(t => t.TriggerId).HasColumnName("TriggerId");
            this.Property(t => t.SubscriptionStatusId).HasColumnName("SubscriptionStatusId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.SubscriptionStatu)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.SubscriptionStatusId);
            this.HasOptional(t => t.Trigger)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(d => d.TriggerId);

        }
    }
}
