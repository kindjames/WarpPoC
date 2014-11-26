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
            this.HasKey(t => t.TerminologyId);

            // Properties
            this.Property(t => t.TerminologyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Term)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Terminology");
            this.Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            this.Property(t => t.Term).HasColumnName("Term");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
