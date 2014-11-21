using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ConfigurationMap : EntityTypeConfiguration<Configuration>
    {
        public ConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationId);

            // Properties
            this.Property(t => t.ConfigurationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Configuration");
            this.Property(t => t.ConfigurationId).HasColumnName("ConfigurationID");
            this.Property(t => t.ConfigurationItemId).HasColumnName("ConfigurationItemID");
            this.Property(t => t.ConfigurationSystemId).HasColumnName("ConfigurationSystemID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LastUpdateAdminId).HasColumnName("LastUpdateAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ConfigurationItem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationItemId);
            this.HasRequired(t => t.ConfigurationSystem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationSystemId);

        }
    }
}
