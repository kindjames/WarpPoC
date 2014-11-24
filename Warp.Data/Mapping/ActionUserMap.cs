using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ActionUserMap : EntityTypeConfiguration<ActionUser>
    {
        public ActionUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionUserId);

            // Properties
            this.Property(t => t.ActionUserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ActionUser");
            this.Property(t => t.ActionUserId).HasColumnName("ActionUserID");
            this.Property(t => t.ActionId).HasColumnName("ActionID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ReadPermission).HasColumnName("ReadPermission");
            this.Property(t => t.WritePermission).HasColumnName("WritePermission");
            this.Property(t => t.CommentPermission).HasColumnName("CommentPermission");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.AddedByUserId).HasColumnName("AddedByUserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.Action)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.ActionId);

        }
    }
}
