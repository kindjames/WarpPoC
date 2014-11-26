using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ConfigurationItemMap : EntityTypeConfiguration<ConfigurationItem>
    {
        public ConfigurationItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationItemId);

            // Properties
            this.Property(t => t.ConfigurationItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ConfigurationItem");
            this.Property(t => t.ConfigurationItemId).HasColumnName("ConfigurationItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ConfigurationTypeId).HasColumnName("ConfigurationTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ConfigurationType)
                .WithMany(t => t.ConfigurationItems)
                .HasForeignKey(d => d.ConfigurationTypeId);

        }
    }
}
