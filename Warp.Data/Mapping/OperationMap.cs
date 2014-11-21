using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
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
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
