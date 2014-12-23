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
            HasKey(t => t.CallInLogId);

            // Properties
            Property(t => t.CallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("CallInLog");
            Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.HighPriority).HasColumnName("HighPriority");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.Visible).HasColumnName("Visible");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
