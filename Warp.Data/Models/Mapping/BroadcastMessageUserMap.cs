using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BroadcastMessageUserMap : EntityTypeConfiguration<BroadcastMessageUser>
    {
        public BroadcastMessageUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BroadcastMessageUserID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BroadcastMessageUser");
            this.Property(t => t.BroadcastMessageUserID).HasColumnName("BroadcastMessageUserID");
            this.Property(t => t.BroadcastMessageID).HasColumnName("BroadcastMessageID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.UserRead).HasColumnName("UserRead");
            this.Property(t => t.DateRead).HasColumnName("DateRead");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.BroadcastMessage)
                .WithMany(t => t.BroadcastMessageUsers)
                .HasForeignKey(d => d.BroadcastMessageID);

        }
    }
}
