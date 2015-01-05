using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerInstanceReportStatusTypeMap : EntityTypeConfiguration<TriggerInstanceReportStatusType>
    {
        public TriggerInstanceReportStatusTypeMap()
        {
            // Primary Key
            HasKey(t => t.TriggerInstanceReportStatusTypeId);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(250);

            Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("TriggerInstanceReportStatusType", "Subscriptions");
            Property(t => t.TriggerInstanceReportStatusTypeId).HasColumnName("TriggerInstanceReportStatusTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
        }
    }
}
