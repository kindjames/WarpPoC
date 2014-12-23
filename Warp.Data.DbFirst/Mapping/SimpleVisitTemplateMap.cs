using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SimpleVisitTemplateMap : EntityTypeConfiguration<SimpleVisitTemplate>
    {
        public SimpleVisitTemplateMap()
        {
            // Primary Key
            HasKey(t => t.SimpleVisitTemplateId);

            // Properties
            Property(t => t.SimpleVisitTemplateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("SimpleVisitTemplate");
            Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.RequiredCount).HasColumnName("RequiredCount");
            Property(t => t.DateCountReached).HasColumnName("DateCountReached");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SimpleVisitTemplates)
                .HasForeignKey(d => d.QuestionnaireId);

        }
    }
}
