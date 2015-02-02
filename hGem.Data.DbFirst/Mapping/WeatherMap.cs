using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class WeatherMap : EntityTypeConfiguration<Weather>
    {
        public WeatherMap()
        {
            // Primary Key
            HasKey(t => t.WeatherId);

            // Properties
            Property(t => t.WeatherId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("Weather");
            Property(t => t.WeatherId).HasColumnName("WeatherID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
