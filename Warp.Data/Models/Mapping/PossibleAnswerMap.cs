using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PossibleAnswerMap : EntityTypeConfiguration<PossibleAnswer>
    {
        public PossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.PossibleAnswerID);

            // Properties
            this.Property(t => t.PossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PossibleAnswer");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.PossibleAnswerTypeID).HasColumnName("PossibleAnswerTypeID");
        }
    }
}
