using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class SimpleVisitTemplateBranchMap : EntityTypeConfiguration<SimpleVisitTemplateBranch>
    {
        public SimpleVisitTemplateBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitTemplateBranchID);

            // Properties
            this.Property(t => t.SimpleVisitTemplateBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitTemplateBranch");
            this.Property(t => t.SimpleVisitTemplateBranchID).HasColumnName("SimpleVisitTemplateBranchID");
            this.Property(t => t.SimpleVisitTemplateID).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
