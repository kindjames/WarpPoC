using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditTableMap : EntityTypeConfiguration<AuditTable>
    {
        public AuditTableMap()
        {
            // Primary Key
            HasKey(t => t.AuditTableId);

            // Properties
            Property(t => t.AuditTableId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Notes)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("AuditTable");
            Property(t => t.AuditTableId).HasColumnName("AuditTableID");
            Property(t => t.TableName).HasColumnName("TableName");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
