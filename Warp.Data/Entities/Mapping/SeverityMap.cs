using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class SeverityMap : EntityTypeConfiguration<Severity>
    {
        public SeverityMap()
        {
            // Primary Key
            this.HasKey(t => t.SeverityID);

            // Properties
            this.Property(t => t.Severity1)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Severity", "Auditing");
            this.Property(t => t.SeverityID).HasColumnName("SeverityID");
            this.Property(t => t.Severity1).HasColumnName("Severity");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
