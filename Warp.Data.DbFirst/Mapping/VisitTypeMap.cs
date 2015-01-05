using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitTypeMap : EntityTypeConfiguration<VisitType>
    {
        public VisitTypeMap()
        {
            // Primary Key
            HasKey(t => t.VisitTypeId);

            // Properties
            Property(t => t.VisitTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("VisitType");
            Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
