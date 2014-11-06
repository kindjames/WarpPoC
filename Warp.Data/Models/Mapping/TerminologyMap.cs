using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TerminologyMap : EntityTypeConfiguration<Terminology>
    {
        public TerminologyMap()
        {
            // Primary Key
            this.HasKey(t => t.TerminologyID);

            // Properties
            this.Property(t => t.TerminologyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Term)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Terminology");
            this.Property(t => t.TerminologyID).HasColumnName("TerminologyID");
            this.Property(t => t.Term).HasColumnName("Term");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DeactivatedDate).HasColumnName("DeactivatedDate");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
