using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SimpleVisitTemplateBranchMap : EntityTypeConfiguration<SimpleVisitTemplateBranch>
    {
        public SimpleVisitTemplateBranchMap()
        {
            // Primary Key
            HasKey(t => t.SimpleVisitTemplateBranchId);

            // Properties
            Property(t => t.SimpleVisitTemplateBranchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("SimpleVisitTemplateBranch");
            Property(t => t.SimpleVisitTemplateBranchId).HasColumnName("SimpleVisitTemplateBranchID");
            Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
