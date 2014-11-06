using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CallInLogMap : EntityTypeConfiguration<CallInLog>
    {
        public CallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.CallInLogID);

            // Properties
            this.Property(t => t.CallInLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CallInLog");
            this.Property(t => t.CallInLogID).HasColumnName("CallInLogID");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.ValidUntil).HasColumnName("ValidUntil");
            this.Property(t => t.HighPriority).HasColumnName("HighPriority");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Visible).HasColumnName("Visible");
        }
    }
}
