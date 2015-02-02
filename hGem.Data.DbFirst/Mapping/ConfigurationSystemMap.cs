using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ConfigurationSystemMap : EntityTypeConfiguration<ConfigurationSystem>
    {
        public ConfigurationSystemMap()
        {
            // Primary Key
            HasKey(t => t.ConfigurationSystemId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ConfigurationSystem");
            Property(t => t.ConfigurationSystemId).HasColumnName("ConfigurationSystemID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
