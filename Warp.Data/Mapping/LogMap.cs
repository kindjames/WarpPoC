using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.context)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.behaviour)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Log");
            this.Property(t => t.LogId).HasColumnName("LogID");
            this.Property(t => t.context).HasColumnName("context");
            this.Property(t => t.context_Id).HasColumnName("context_id");
            this.Property(t => t.behaviour).HasColumnName("behaviour");
            this.Property(t => t.user_Id).HasColumnName("user_id");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
