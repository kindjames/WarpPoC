using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AbsenceTypeMap : EntityTypeConfiguration<AbsenceType>
    {
        public AbsenceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AbsenceTypeId);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AbsenceType");
            this.Property(t => t.AbsenceTypeId).HasColumnName("AbsenceTypeID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
