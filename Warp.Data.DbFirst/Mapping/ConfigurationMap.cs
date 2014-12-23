using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ConfigurationMap : EntityTypeConfiguration<Configuration>
    {
        public ConfigurationMap()
        {
            // Primary Key
            HasKey(t => t.ConfigurationId);

            // Properties
            Property(t => t.ConfigurationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("Configuration");
            Property(t => t.ConfigurationId).HasColumnName("ConfigurationID");
            Property(t => t.ConfigurationItemId).HasColumnName("ConfigurationItemID");
            Property(t => t.ConfigurationSystemId).HasColumnName("ConfigurationSystemID");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.LastUpdateAdminId).HasColumnName("LastUpdateAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ConfigurationItem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationItemId);
            HasRequired(t => t.ConfigurationSystem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationSystemId);

        }
    }
}
