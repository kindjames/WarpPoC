using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ActionUserMap : EntityTypeConfiguration<ActionUser>
    {
        public ActionUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionUserID);

            // Properties
            this.Property(t => t.ActionUserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ActionUser");
            this.Property(t => t.ActionUserID).HasColumnName("ActionUserID");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ReadPermission).HasColumnName("ReadPermission");
            this.Property(t => t.WritePermission).HasColumnName("WritePermission");
            this.Property(t => t.CommentPermission).HasColumnName("CommentPermission");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.AddedByUserID).HasColumnName("AddedByUserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Action)
                .WithMany(t => t.ActionUsers)
                .HasForeignKey(d => d.ActionID);

        }
    }
}
