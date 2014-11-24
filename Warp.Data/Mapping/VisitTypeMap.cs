using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitTypeMap : EntityTypeConfiguration<VisitType>
    {
        public VisitTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTypeId);

            // Properties
            this.Property(t => t.VisitTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VisitType");
            this.Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
