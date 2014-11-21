using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ConfigurationSystemMap : EntityTypeConfiguration<ConfigurationSystem>
    {
        public ConfigurationSystemMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationSystemId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConfigurationSystem");
            this.Property(t => t.ConfigurationSystemId).HasColumnName("ConfigurationSystemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
