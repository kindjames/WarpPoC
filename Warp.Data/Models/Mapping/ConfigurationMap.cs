using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ConfigurationMap : EntityTypeConfiguration<Configuration>
    {
        public ConfigurationMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationID);

            // Properties
            this.Property(t => t.ConfigurationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Configuration");
            this.Property(t => t.ConfigurationID).HasColumnName("ConfigurationID");
            this.Property(t => t.ConfigurationItemID).HasColumnName("ConfigurationItemID");
            this.Property(t => t.ConfigurationSystemID).HasColumnName("ConfigurationSystemID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LastUpdateAdminID).HasColumnName("LastUpdateAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ConfigurationItem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationItemID);
            this.HasRequired(t => t.ConfigurationSystem)
                .WithMany(t => t.Configurations)
                .HasForeignKey(d => d.ConfigurationSystemID);

        }
    }
}
