using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ReportProblemActionTypeMap : EntityTypeConfiguration<ReportProblemActionType>
    {
        public ReportProblemActionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemActionTypeID);

            // Properties
            this.Property(t => t.ReportProblemActionTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ReportProblemActionType");
            this.Property(t => t.ReportProblemActionTypeID).HasColumnName("ReportProblemActionTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
