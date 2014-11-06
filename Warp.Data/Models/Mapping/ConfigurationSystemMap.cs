using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ConfigurationSystemMap : EntityTypeConfiguration<ConfigurationSystem>
    {
        public ConfigurationSystemMap()
        {
            // Primary Key
            this.HasKey(t => t.ConfigurationSystemID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConfigurationSystem");
            this.Property(t => t.ConfigurationSystemID).HasColumnName("ConfigurationSystemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
