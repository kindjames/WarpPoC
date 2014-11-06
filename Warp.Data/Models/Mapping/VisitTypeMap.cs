using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitTypeMap : EntityTypeConfiguration<VisitType>
    {
        public VisitTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTypeID);

            // Properties
            this.Property(t => t.VisitTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VisitType");
            this.Property(t => t.VisitTypeID).HasColumnName("VisitTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
