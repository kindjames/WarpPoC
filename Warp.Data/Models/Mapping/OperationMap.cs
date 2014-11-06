using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class OperationMap : EntityTypeConfiguration<Operation>
    {
        public OperationMap()
        {
            // Primary Key
            this.HasKey(t => t.OperationId);

            // Properties
            this.Property(t => t.Method)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("Operation", "Auditing");
            this.Property(t => t.OperationId).HasColumnName("OperationId");
            this.Property(t => t.Method).HasColumnName("Method");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
