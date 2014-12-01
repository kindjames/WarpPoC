using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class GroupUserMap : EntityTypeConfiguration<GroupUser>
    {
        public GroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupUserId);

            // Properties
            this.Property(t => t.GroupUserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GroupUser");
            this.Property(t => t.GroupUserId).HasColumnName("GroupUserID");
            this.Property(t => t.GroupId).HasColumnName("GroupID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.Group)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
