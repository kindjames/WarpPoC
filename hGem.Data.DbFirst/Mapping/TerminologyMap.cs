using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TerminologyMap : EntityTypeConfiguration<Terminology>
    {
        public TerminologyMap()
        {
            // Primary Key
            HasKey(t => t.TerminologyId);

            // Properties
            Property(t => t.TerminologyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Term)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Terminology");
            Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            Property(t => t.Term).HasColumnName("Term");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
