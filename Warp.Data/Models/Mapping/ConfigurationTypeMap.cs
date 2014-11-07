using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ConfigurationTypeMap : EntityTypeConfiguration<ConfigurationType>
    {
        public ConfigurationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConfigurationType");
            this.Property(t => t.ConfigurationTypeID).HasColumnName("ConfigurationTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
