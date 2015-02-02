using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BroadcastMessageUserMap : EntityTypeConfiguration<BroadcastMessageUser>
    {
        public BroadcastMessageUserMap()
        {
            // Primary Key
            HasKey(t => t.BroadcastMessageUserId);

            // Properties
            // Table & Column Mappings
            ToTable("BroadcastMessageUser");
            Property(t => t.BroadcastMessageUserId).HasColumnName("BroadcastMessageUserID");
            Property(t => t.BroadcastMessageId).HasColumnName("BroadcastMessageID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.UserRead).HasColumnName("UserRead");
            Property(t => t.DateRead).HasColumnName("DateRead");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.BroadcastMessage)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.BroadcastMessageId);

        }
    }
}
