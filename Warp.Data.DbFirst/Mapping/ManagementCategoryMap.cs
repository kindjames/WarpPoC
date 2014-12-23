using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ManagementCategoryMap : EntityTypeConfiguration<ManagementCategory>
    {
        public ManagementCategoryMap()
        {
            // Primary Key
            HasKey(t => t.ManagementCategoryId);

            // Properties
            Property(t => t.ManagementCategoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("ManagementCategory");
            Property(t => t.ManagementCategoryId).HasColumnName("ManagementCategoryID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
