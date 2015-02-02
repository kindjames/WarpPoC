using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SchemaMap : EntityTypeConfiguration<Schema>
    {
        public SchemaMap()
        {
            // Primary Key
            HasKey(t => t.SchemaVersion);

            // Properties
            Property(t => t.SchemaVersion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Schema", "SignalR");
            Property(t => t.SchemaVersion).HasColumnName("SchemaVersion");
        }
    }
}
