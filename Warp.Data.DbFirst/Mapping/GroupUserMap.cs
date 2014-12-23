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
            HasKey(t => t.GroupUserId);

            // Properties
            Property(t => t.GroupUserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("GroupUser");
            Property(t => t.GroupUserId).HasColumnName("GroupUserID");
            Property(t => t.GroupId).HasColumnName("GroupID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.Group)
                .WithMany(t => t.GroupUsers)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
