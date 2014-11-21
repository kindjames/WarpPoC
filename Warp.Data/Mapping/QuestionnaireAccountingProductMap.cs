using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionnaireAccountingProductMap : EntityTypeConfiguration<QuestionnaireAccountingProduct>
    {
        public QuestionnaireAccountingProductMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireAccountingProductId);

            // Properties
            this.Property(t => t.QuestionnaireAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionnaireAccountingProduct");
            this.Property(t => t.QuestionnaireAccountingProductId).HasColumnName("QuestionnaireAccountingProductID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasOptional(t => t.SubQuestionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
