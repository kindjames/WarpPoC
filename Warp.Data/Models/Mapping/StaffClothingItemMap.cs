using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffClothingItemMap : EntityTypeConfiguration<StaffClothingItem>
    {
        public StaffClothingItemMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffClothingItemID);

            // Properties
            this.Property(t => t.StaffClothingItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ImagePath)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("StaffClothingItem");
            this.Property(t => t.StaffClothingItemID).HasColumnName("StaffClothingItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.GenderID).HasColumnName("GenderID");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");

            // Relationships
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.StaffClothingItems)
                .HasForeignKey(d => d.GenderID);

        }
    }
}
