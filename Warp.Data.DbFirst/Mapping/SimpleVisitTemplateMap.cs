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
            this.HasKey(t => t.SimpleVisitTemplateId);

            // Properties
            this.Property(t => t.SimpleVisitTemplateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SimpleVisitTemplate");
            this.Property(t => t.SimpleVisitTemplateId).HasColumnName("SimpleVisitTemplateID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.RequiredCount).HasColumnName("RequiredCount");
            this.Property(t => t.DateCountReached).HasColumnName("DateCountReached");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.SimpleVisitTemplates)
                .HasForeignKey(d => d.QuestionnaireId);

        }
    }
}
