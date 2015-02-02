using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class OperationMap : EntityTypeConfiguration<Operation>
    {
        public OperationMap()
        {
            // Primary Key
            HasKey(t => t.OperationId);

            // Properties
            Property(t => t.Method)
                .IsRequired()
                .HasMaxLength(6);

            // Table & Column Mappings
            ToTable("Operation", "Auditing");
            Property(t => t.OperationId).HasColumnName("OperationId");
            Property(t => t.Method).HasColumnName("Method");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
