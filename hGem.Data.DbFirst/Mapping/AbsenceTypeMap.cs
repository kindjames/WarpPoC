using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AbsenceTypeMap : EntityTypeConfiguration<AbsenceType>
    {
        public AbsenceTypeMap()
        {
            // Primary Key
            HasKey(t => t.AbsenceTypeId);

            // Properties
            Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AbsenceType");
            Property(t => t.AbsenceTypeId).HasColumnName("AbsenceTypeID");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
