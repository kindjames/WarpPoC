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
            this.HasKey(t => t.BriefConfigurationId);

            // Properties
            this.Property(t => t.BriefConfigurationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BriefConfiguration");
            this.Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            this.Property(t => t.BriefId).HasColumnName("BriefID");
            this.Property(t => t.BriefSectionId).HasColumnName("BriefSectionID");
            this.Property(t => t.BriefItemId).HasColumnName("BriefItemID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefId);
            this.HasRequired(t => t.BriefItem)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefItemId);
            this.HasRequired(t => t.BriefSection)
                .WithMany(t => t.BriefConfigurations)
                .HasForeignKey(d => d.BriefSectionId);

        }
    }
}
