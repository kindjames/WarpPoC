using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BriefConfigurationMap : EntityTypeConfiguration<BriefConfiguration>
    {
        public BriefConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefConfigurationID);

            // Properties
            this.Property(t => t.BriefConfigurationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BriefConfiguration");
            this.Property(t => t.BriefConfigurationID).HasColumnName("BriefConfigurationID");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.BriefSectionID).HasColumnName("BriefSectionID");
            this.Property(t => t.BriefItemID).HasColumnName("BriefItemID");
            this.Property(t => t.Text).HasColumnName("Text");

            // Relationships
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefID);
            this.HasRequired(t => t.BriefItem)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefItemID);
            this.HasRequired(t => t.BriefSection)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefSectionID);

        }
    }
}
