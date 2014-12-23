using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffClothingItemMap : EntityTypeConfiguration<StaffClothingItem>
    {
        public StaffClothingItemMap()
        {
            // Primary Key
            HasKey(t => t.StaffClothingItemId);

            // Properties
            Property(t => t.StaffClothingItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.ImagePath)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("StaffClothingItem");
            Property(t => t.StaffClothingItemId).HasColumnName("StaffClothingItemID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.GenderId).HasColumnName("GenderID");
            Property(t => t.ImagePath).HasColumnName("ImagePath");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Gender)
                .WithMany(t => t.StaffClothingItems)
                .HasForeignKey(d => d.GenderId);

        }
    }
}
