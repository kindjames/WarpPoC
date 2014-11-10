using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class LogoMap : EntityTypeConfiguration<Logo>
    {
        public LogoMap()
        {
            // Primary Key
            this.HasKey(t => t.LogoID);

            // Properties
            this.Property(t => t.LogoPath)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.OriginalFileName)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Logo", "Client");
            this.Property(t => t.LogoID).HasColumnName("LogoID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.LogoPath).HasColumnName("LogoPath");
            this.Property(t => t.OriginalFileName).HasColumnName("OriginalFileName");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
