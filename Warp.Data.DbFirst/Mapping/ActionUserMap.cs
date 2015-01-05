using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionUserMap : EntityTypeConfiguration<ActionUser>
    {
        public ActionUserMap()
        {
            // Primary Key
            HasKey(t => t.ActionUserId);

            // Properties
            Property(t => t.ActionUserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ActionUser");
            Property(t => t.ActionUserId).HasColumnName("ActionUserID");
            Property(t => t.ActionId).HasColumnName("ActionID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.Timestamp).HasColumnName("Timestamp");
            Property(t => t.ReadPermission).HasColumnName("ReadPermission");
            Property(t => t.WritePermission).HasColumnName("WritePermission");
            Property(t => t.CommentPermission).HasColumnName("CommentPermission");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.AddedByUserId).HasColumnName("AddedByUserID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.Action)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.ActionId);

        }
    }
}
