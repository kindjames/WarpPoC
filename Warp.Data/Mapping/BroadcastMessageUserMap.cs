using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BroadcastMessageUserMap : EntityTypeConfiguration<BroadcastMessageUser>
    {
        public BroadcastMessageUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BroadcastMessageUserId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BroadcastMessageUser");
            this.Property(t => t.BroadcastMessageUserId).HasColumnName("BroadcastMessageUserID");
            this.Property(t => t.BroadcastMessageId).HasColumnName("BroadcastMessageID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.UserRead).HasColumnName("UserRead");
            this.Property(t => t.DateRead).HasColumnName("DateRead");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.BroadcastMessage)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.BroadcastMessageId);

        }
    }
}
