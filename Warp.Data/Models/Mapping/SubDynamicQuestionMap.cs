using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubDynamicQuestionMap : EntityTypeConfiguration<SubDynamicQuestion>
    {
        public SubDynamicQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.SubDynamicQuestionID);

            // Properties
            this.Property(t => t.SubDynamicQuestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SubDynamicQuestion");
            this.Property(t => t.SubDynamicQuestionID).HasColumnName("SubDynamicQuestionID");
            this.Property(t => t.MasterSubQuestionnaireQuestionOverwriteID).HasColumnName("MasterSubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.ChildSubQuestionnaireQuestionOverwriteID).HasColumnName("ChildSubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasRequired(t => t.SubQuestionnaireQuestionOverwrite)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.ChildSubQuestionnaireQuestionOverwriteID);
            this.HasRequired(t => t.SubQuestionnaireQuestionOverwrite1)
                .WithMany(t => t.SubDynamicQuestions1)
                .HasForeignKey(d => d.MasterSubQuestionnaireQuestionOverwriteID);

        }
    }
}
