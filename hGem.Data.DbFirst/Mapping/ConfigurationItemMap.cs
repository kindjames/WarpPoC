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
            HasKey(t => t.ConfigurationItemId);

            // Properties
            Property(t => t.ConfigurationItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("ConfigurationItem");
            Property(t => t.ConfigurationItemId).HasColumnName("ConfigurationItemID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.ConfigurationTypeId).HasColumnName("ConfigurationTypeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ConfigurationType)
                .WithMany(t => t.ConfigurationItems)
                .HasForeignKey(d => d.ConfigurationTypeId);

        }
    }
}
