using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class RegionQuestionnaireMap : EntityTypeConfiguration<RegionQuestionnaire>
    {
        public RegionQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionQuestionnaireID);

            // Properties
            this.Property(t => t.RegionQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RegionQuestionnaire");
            this.Property(t => t.RegionQuestionnaireID).HasColumnName("RegionQuestionnaireID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.RegionID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
