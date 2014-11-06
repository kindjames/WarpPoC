using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SimpleVisitTemplateMap : EntityTypeConfiguration<SimpleVisitTemplate>
    {
        public SimpleVisitTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.SimpleVisitTemplateID);

            // Properties
            this.Property(t => t.SimpleVisitTemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitTemplate");
            this.Property(t => t.SimpleVisitTemplateID).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.RequiredCount).HasColumnName("RequiredCount");
            this.Property(t => t.CountReached).HasColumnName("CountReached");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SimpleVisitTemplates)
                .HasForeignKey(d => d.QuestionnaireID);

        }
    }
}
