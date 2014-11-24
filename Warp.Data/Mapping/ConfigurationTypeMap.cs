using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ConfigurationTypeMap : EntityTypeConfiguration<ConfigurationType>
    {
        public ConfigurationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConfigurationType");
            this.Property(t => t.ConfigurationTypeId).HasColumnName("ConfigurationTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
