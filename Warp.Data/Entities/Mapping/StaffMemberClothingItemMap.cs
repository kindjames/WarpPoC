using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class StaffMemberClothingItemMap : EntityTypeConfiguration<StaffMemberClothingItem>
    {
        public StaffMemberClothingItemMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffMemberClothingItemID);

            // Properties
            this.Property(t => t.StaffMemberClothingItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StaffMemberClothingItem");
            this.Property(t => t.StaffMemberClothingItemID).HasColumnName("StaffMemberClothingItemID");
            this.Property(t => t.StaffMemberID).HasColumnName("StaffMemberID");
            this.Property(t => t.StaffClothingItemID).HasColumnName("StaffClothingItemID");
            this.Property(t => t.StaffClothingColourID).HasColumnName("StaffClothingColourID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.StaffClothingColour)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingColourID);
            this.HasRequired(t => t.StaffClothingItem)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffClothingItemID);
            this.HasRequired(t => t.StaffMember)
                .WithMany(t => t.StaffMemberClothingItems)
                .HasForeignKey(d => d.StaffMemberID);

        }
    }
}
