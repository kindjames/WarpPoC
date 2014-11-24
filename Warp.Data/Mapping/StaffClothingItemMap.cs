using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffClothingItemMap : EntityTypeConfiguration<StaffClothingItem>
    {
        public StaffClothingItemMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffClothingItemId);

            // Properties
            this.Property(t => t.StaffClothingItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ImagePath)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("StaffClothingItem");
            this.Property(t => t.StaffClothingItemId).HasColumnName("StaffClothingItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.GenderId).HasColumnName("GenderID");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.StaffClothingItems)
                .HasForeignKey(d => d.GenderId);

        }
    }
}
