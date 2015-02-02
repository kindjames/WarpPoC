using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AbsenceInstanceMap : EntityTypeConfiguration<AbsenceInstance>
    {
        public AbsenceInstanceMap()
        {
            // Primary Key
            HasKey(t => t.AbsenceInstanceId);

            // Properties
            Property(t => t.AbsenceInstanceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AbsenceInstance");
            Property(t => t.AbsenceInstanceId).HasColumnName("AbsenceInstanceID");
            Property(t => t.AbsenceTypeId).HasColumnName("AbsenceTypeID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.ApprovedByAdminId).HasColumnName("ApprovedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AbsenceType)
                .WithMany(t => t.AbsenceInstances)
                .HasForeignKey(d => d.AbsenceTypeId);

        }
    }
}
