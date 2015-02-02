using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditingDatabaseMap : EntityTypeConfiguration<AuditingDatabase>
    {
        public AuditingDatabaseMap()
        {
            // Primary Key
            HasKey(t => t.DatabaseId);

            // Properties
            Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.ColumnName)
                .IsRequired()
                .HasMaxLength(255);

            Property(t => t.PreviousValue)
                .IsRequired();

            Property(t => t.NewValue)
                .IsRequired();

            // Table & Column Mappings
            ToTable("Database", "Auditing");
            Property(t => t.DatabaseId).HasColumnName("DatabaseID");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.OperationId).HasColumnName("OperationId");
            Property(t => t.IdentityId).HasColumnName("IdentityId");
            Property(t => t.TableName).HasColumnName("TableName");
            Property(t => t.ColumnName).HasColumnName("ColumnName");
            Property(t => t.PreviousValue).HasColumnName("PreviousValue");
            Property(t => t.NewValue).HasColumnName("NewValue");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Operation)
                .WithMany(t => t.AuditingDatabases)
                .HasForeignKey(d => d.OperationId);

        }
    }
}
