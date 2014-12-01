using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CallInLogMap : EntityTypeConfiguration<CallInLog>
    {
        public CallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.CallInLogId);

            // Properties
            this.Property(t => t.CallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CallInLog");
            this.Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            this.Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.HighPriority).HasColumnName("HighPriority");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
