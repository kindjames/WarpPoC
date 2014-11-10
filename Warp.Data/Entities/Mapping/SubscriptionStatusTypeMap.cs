using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class SubscriptionStatusTypeMap : EntityTypeConfiguration<SubscriptionStatusType>
    {
        public SubscriptionStatusTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionStatusTypeId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(250);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("SubscriptionStatusType", "Subscriptions");
            this.Property(t => t.SubscriptionStatusTypeId).HasColumnName("SubscriptionStatusTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
