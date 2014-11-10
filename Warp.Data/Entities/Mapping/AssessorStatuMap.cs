using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AssessorStatuMap : EntityTypeConfiguration<AssessorStatu>
    {
        public AssessorStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorStatusID);

            // Properties
            this.Property(t => t.AssessorStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InternalName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ExternalName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssessorStatus");
            this.Property(t => t.AssessorStatusID).HasColumnName("AssessorStatusID");
            this.Property(t => t.InternalName).HasColumnName("InternalName");
            this.Property(t => t.ExternalName).HasColumnName("ExternalName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
