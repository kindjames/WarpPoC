using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefConfigurationMap : EntityTypeConfiguration<BriefConfiguration>
    {
        public BriefConfigurationMap()
        {
            // Primary Key
            HasKey(t => t.BriefConfigurationId);

            // Properties
            Property(t => t.BriefConfigurationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("BriefConfiguration");
            Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.BriefSectionId).HasColumnName("BriefSectionID");
            Property(t => t.BriefItemId).HasColumnName("BriefItemID");
            Property(t => t.Text).HasColumnName("Text");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brief)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefId);
            HasRequired(t => t.BriefItem)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefItemId);
            HasRequired(t => t.BriefSection)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefSectionId);

        }
    }
}
