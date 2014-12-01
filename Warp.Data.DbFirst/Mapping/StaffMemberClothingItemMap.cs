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
            this.HasKey(t => t.StaffMemberClothingItemId);

            // Properties
            this.Property(t => t.StaffMemberClothingItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StaffMemberClothingItem");
            this.Property(t => t.StaffMemberClothingItemId).HasColumnName("StaffMemberClothingItemID");
            this.Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            this.Property(t => t.StaffClothingItemId).HasColumnName("StaffClothingItemID");
            this.Property(t => t.StaffClothingColourId).HasColumnName("StaffClothingColourID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.StaffClothingColour)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingColourId);
            this.HasRequired(t => t.StaffClothingItem)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingItemId);
            this.HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffMemberId);

        }
    }
}
