using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BriefSectionMap : EntityTypeConfiguration<BriefSection>
    {
        public BriefSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefSectionID);

            // Properties
            this.Property(t => t.BriefSectionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BriefSection");
            this.Property(t => t.BriefSectionID).HasColumnName("BriefSectionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
