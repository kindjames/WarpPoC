using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DynamicTextMap : EntityTypeConfiguration<DynamicText>
    {
        public DynamicTextMap()
        {
            // Primary Key
            HasKey(t => t.DynamicTextId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("DynamicText", "Subscriptions");
            Property(t => t.DynamicTextId).HasColumnName("DynamicTextId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Tag).HasColumnName("Tag");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
