using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ManagementCategoryMap : EntityTypeConfiguration<ManagementCategory>
    {
        public ManagementCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagementCategoryID);

            // Properties
            this.Property(t => t.ManagementCategoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ManagementCategory");
            this.Property(t => t.ManagementCategoryID).HasColumnName("ManagementCategoryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
