using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class RegionQuestionnaireMap : EntityTypeConfiguration<RegionQuestionnaire>
    {
        public RegionQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionQuestionnaireId);

            // Properties
            this.Property(t => t.RegionQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RegionQuestionnaire");
            this.Property(t => t.RegionQuestionnaireId).HasColumnName("RegionQuestionnaireID");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.RegionId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
