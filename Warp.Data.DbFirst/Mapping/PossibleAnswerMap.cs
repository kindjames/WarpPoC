using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PossibleAnswerMap : EntityTypeConfiguration<PossibleAnswer>
    {
        public PossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.PossibleAnswerId);

            // Properties
            this.Property(t => t.PossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PossibleAnswer");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.PossibleAnswerTypeId).HasColumnName("PossibleAnswerTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
