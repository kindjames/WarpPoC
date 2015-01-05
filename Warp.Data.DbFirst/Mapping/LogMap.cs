using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            HasKey(t => t.LogId);

            // Properties
            Property(t => t.context)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.behaviour)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Log");
            Property(t => t.LogId).HasColumnName("LogID");
            Property(t => t.context).HasColumnName("context");
            Property(t => t.context_Id).HasColumnName("context_id");
            Property(t => t.behaviour).HasColumnName("behaviour");
            Property(t => t.user_Id).HasColumnName("user_id");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
