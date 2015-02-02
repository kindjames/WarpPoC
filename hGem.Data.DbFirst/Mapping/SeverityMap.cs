using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SeverityMap : EntityTypeConfiguration<Severity>
    {
        public SeverityMap()
        {
            // Primary Key
            HasKey(t => t.SeverityId);

            // Properties
            Property(t => t.Severity1)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            ToTable("Severity", "Auditing");
            Property(t => t.SeverityId).HasColumnName("SeverityID");
            Property(t => t.Severity1).HasColumnName("Severity");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
