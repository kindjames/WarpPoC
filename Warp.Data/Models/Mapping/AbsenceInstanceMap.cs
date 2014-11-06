using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AbsenceInstanceMap : EntityTypeConfiguration<AbsenceInstance>
    {
        public AbsenceInstanceMap()
        {
            // Primary Key
            this.HasKey(t => t.AbsenceInstanceID);

            // Properties
            this.Property(t => t.AbsenceInstanceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AbsenceInstance");
            this.Property(t => t.AbsenceInstanceID).HasColumnName("AbsenceInstanceID");
            this.Property(t => t.AbsenceTypeID).HasColumnName("AbsenceTypeID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.ValidFromDate).HasColumnName("ValidFromDate");
            this.Property(t => t.ValidToDate).HasColumnName("ValidToDate");
            this.Property(t => t.ApprovedByAdminID).HasColumnName("ApprovedByAdminID");

            // Relationships
            this.HasRequired(t => t.AbsenceType)
                .WithMany(t => t.AbsenceInstances)
                .HasForeignKey(d => d.AbsenceTypeID);

        }
    }
}
