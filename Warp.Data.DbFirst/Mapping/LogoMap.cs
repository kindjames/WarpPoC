using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class LogoMap : EntityTypeConfiguration<Logo>
    {
        public LogoMap()
        {
            // Primary Key
            HasKey(t => t.LogoId);

            // Properties
            Property(t => t.LogoPath)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.OriginalFileName)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Logo", "Client");
            Property(t => t.LogoId).HasColumnName("LogoID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.LogoPath).HasColumnName("LogoPath");
            Property(t => t.OriginalFileName).HasColumnName("OriginalFileName");
            Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            Property(t => t.Created).HasColumnName("Created");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
