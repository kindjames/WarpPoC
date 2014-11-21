using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SimpleVisitTemplateBranchMap : EntityTypeConfiguration<SimpleVisitTemplateBranch>
    {
        public SimpleVisitTemplateBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitTemplateBranchId);

            // Properties
            this.Property(t => t.SimpleVisitTemplateBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitTemplateBranch");
            this.Property(t => t.SimpleVisitTemplateBranchId).HasColumnName("SimpleVisitTemplateBranchID");
            this.Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
