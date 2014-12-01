using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditingDatabaseMap : EntityTypeConfiguration<AuditingDatabase>
    {
        public AuditingDatabaseMap()
        {
            // Primary Key
            this.HasKey(t => t.DatabaseId);

            // Properties
            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ColumnName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PreviousValue)
                .IsRequired();

            this.Property(t => t.NewValue)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Database", "Auditing");
            this.Property(t => t.DatabaseId).HasColumnName("DatabaseID");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.OperationId).HasColumnName("OperationId");
            this.Property(t => t.IdentityId).HasColumnName("IdentityId");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.ColumnName).HasColumnName("ColumnName");
            this.Property(t => t.PreviousValue).HasColumnName("PreviousValue");
            this.Property(t => t.NewValue).HasColumnName("NewValue");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Operation)
                .WithMany(t => t.AuditingDatabases)
                .HasForeignKey(d => d.OperationId);

        }
    }
}
