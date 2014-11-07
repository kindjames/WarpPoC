using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TriggerInstanceMap : EntityTypeConfiguration<TriggerInstance>
    {
        public TriggerInstanceMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerInstanceId);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(600);

            // Table & Column Mappings
            this.ToTable("TriggerInstance", "Subscriptions");
            this.Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            this.Property(t => t.TriggerId).HasColumnName("TriggerId");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateProcessStarted).HasColumnName("DateProcessStarted");
            this.Property(t => t.DateProcessEnded).HasColumnName("DateProcessEnded");
            this.Property(t => t.DateTriggered).HasColumnName("DateTriggered");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Manual).HasColumnName("Manual");
            this.Property(t => t.ResendAll).HasColumnName("ResendAll");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
