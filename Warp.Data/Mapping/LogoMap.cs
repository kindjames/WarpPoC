using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class LogoMap : EntityTypeConfiguration<Logo>
    {
        public LogoMap()
        {
            // Primary Key
            this.HasKey(t => t.LogoId);

            // Properties
            this.Property(t => t.LogoPath)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OriginalFileName)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Logo", "Client");
            this.Property(t => t.LogoId).HasColumnName("LogoID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.LogoPath).HasColumnName("LogoPath");
            this.Property(t => t.OriginalFileName).HasColumnName("OriginalFileName");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
