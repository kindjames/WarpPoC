using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefSectionMap : EntityTypeConfiguration<BriefSection>
    {
        public BriefSectionMap()
        {
            // Primary Key
            HasKey(t => t.BriefSectionId);

            // Properties
            Property(t => t.BriefSectionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("BriefSection");
            Property(t => t.BriefSectionId).HasColumnName("BriefSectionID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
