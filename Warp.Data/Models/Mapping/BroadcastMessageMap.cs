using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BroadcastMessageMap : EntityTypeConfiguration<BroadcastMessage>
    {
        public BroadcastMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.BroadcastMessageID);

            // Properties
            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("BroadcastMessage");
            this.Property(t => t.BroadcastMessageID).HasColumnName("BroadcastMessageID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateChecked).HasColumnName("DateChecked");
            this.Property(t => t.CheckedByAdminID).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.RemovedDate).HasColumnName("RemovedDate");
            this.Property(t => t.RemovedByAdminID).HasColumnName("RemovedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
