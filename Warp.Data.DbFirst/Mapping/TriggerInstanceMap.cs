using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerInstanceMap : EntityTypeConfiguration<TriggerInstance>
    {
        public TriggerInstanceMap()
        {
            // Primary Key
            HasKey(t => t.TriggerInstanceId);

            // Properties
            Property(t => t.Notes)
                .HasMaxLength(600);

            // Table & Column Mappings
            ToTable("TriggerInstance", "Subscriptions");
            Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            Property(t => t.TriggerId).HasColumnName("TriggerId");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateProcessStarted).HasColumnName("DateProcessStarted");
            Property(t => t.DateProcessEnded).HasColumnName("DateProcessEnded");
            Property(t => t.DateTriggered).HasColumnName("DateTriggered");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Manual).HasColumnName("Manual");
            Property(t => t.ResendAll).HasColumnName("ResendAll");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
