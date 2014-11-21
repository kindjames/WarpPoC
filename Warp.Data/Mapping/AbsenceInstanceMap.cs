using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AbsenceInstanceMap : EntityTypeConfiguration<AbsenceInstance>
    {
        public AbsenceInstanceMap()
        {
            // Primary Key
            this.HasKey(t => t.AbsenceInstanceId);

            // Properties
            this.Property(t => t.AbsenceInstanceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AbsenceInstance");
            this.Property(t => t.AbsenceInstanceId).HasColumnName("AbsenceInstanceID");
            this.Property(t => t.AbsenceTypeId).HasColumnName("AbsenceTypeID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.ApprovedByAdminId).HasColumnName("ApprovedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AbsenceType)
                .WithMany(t => t.AbsenceInstances)
                .HasForeignKey(d => d.AbsenceTypeId);

        }
    }
}
