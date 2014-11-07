using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AuditTableMap : EntityTypeConfiguration<AuditTable>
    {
        public AuditTableMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditTableID);

            // Properties
            this.Property(t => t.AuditTableID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Notes)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("AuditTable");
            this.Property(t => t.AuditTableID).HasColumnName("AuditTableID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
