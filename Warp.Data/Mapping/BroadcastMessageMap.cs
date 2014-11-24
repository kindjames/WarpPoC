using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BroadcastMessageMap : EntityTypeConfiguration<BroadcastMessage>
    {
        public BroadcastMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.BroadcastMessageId);

            // Properties
            this.Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("BroadcastMessage");
            this.Property(t => t.BroadcastMessageId).HasColumnName("BroadcastMessageID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateChecked).HasColumnName("DateChecked");
            this.Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
