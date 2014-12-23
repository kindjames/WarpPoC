using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffMemberClothingItemMap : EntityTypeConfiguration<StaffMemberClothingItem>
    {
        public StaffMemberClothingItemMap()
        {
            // Primary Key
            HasKey(t => t.StaffMemberClothingItemId);

            // Properties
            Property(t => t.StaffMemberClothingItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("StaffMemberClothingItem");
            Property(t => t.StaffMemberClothingItemId).HasColumnName("StaffMemberClothingItemID");
            Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            Property(t => t.StaffClothingItemId).HasColumnName("StaffClothingItemID");
            Property(t => t.StaffClothingColourId).HasColumnName("StaffClothingColourID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.StaffClothingColour)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingColourId);
            HasRequired(t => t.StaffClothingItem)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingItemId);
            HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffMemberId);

        }
    }
}
