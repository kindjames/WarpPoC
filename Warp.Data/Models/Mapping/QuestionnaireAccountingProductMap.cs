using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionnaireAccountingProductMap : EntityTypeConfiguration<QuestionnaireAccountingProduct>
    {
        public QuestionnaireAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireAccountingProductID);

            // Properties
            this.Property(t => t.QuestionnaireAccountingProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionnaireAccountingProduct");
            this.Property(t => t.QuestionnaireAccountingProductID).HasColumnName("QuestionnaireAccountingProductID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.AccountingProductID).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.AccountingProductID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasOptional(t => t.SubQuestionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
