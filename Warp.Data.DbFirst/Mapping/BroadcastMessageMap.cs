using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BroadcastMessageMap : EntityTypeConfiguration<BroadcastMessage>
    {
        public BroadcastMessageMap()
        {
            // Primary Key
            HasKey(t => t.BroadcastMessageId);

            // Properties
            Property(t => t.Message)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("BroadcastMessage");
            Property(t => t.BroadcastMessageId).HasColumnName("BroadcastMessageID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateChecked).HasColumnName("DateChecked");
            Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            Property(t => t.Message).HasColumnName("Message");
            Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            Property(t => t.RemovedByAdminId).HasColumnName("RemovedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
