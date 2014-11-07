using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class GroupUserMap : EntityTypeConfiguration<GroupUser>
    {
        public GroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUserID);

            // Properties
            this.Property(t => t.GroupUserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GroupUser");
            this.Property(t => t.GroupUserID).HasColumnName("GroupUserID");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.GroupID);

        }
    }
}
