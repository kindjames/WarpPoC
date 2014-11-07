using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ConfigurationItemMap : EntityTypeConfiguration<ConfigurationItem>
    {
        public ConfigurationItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationItemID);

            // Properties
            this.Property(t => t.ConfigurationItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ConfigurationItem");
            this.Property(t => t.ConfigurationItemID).HasColumnName("ConfigurationItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ConfigurationTypeID).HasColumnName("ConfigurationTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ConfigurationType)
                .WithMany(t => t.ConfigurationItems)
                .HasForeignKey(d => d.ConfigurationTypeID);

        }
    }
}
