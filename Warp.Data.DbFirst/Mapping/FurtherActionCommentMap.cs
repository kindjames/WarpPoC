using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class FurtherActionCommentMap : EntityTypeConfiguration<FurtherActionComment>
    {
        public FurtherActionCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.FurtherActionCommentId);

            // Properties
            this.Property(t => t.FurtherActionCommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment1)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.Comment2)
                .HasMaxLength(500);

            this.Property(t => t.Comment3)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("FurtherActionComment");
            this.Property(t => t.FurtherActionCommentId).HasColumnName("FurtherActionCommentID");
            this.Property(t => t.ActionCommentId).HasColumnName("ActionCommentID");
            this.Property(t => t.Comment1).HasColumnName("Comment1");
            this.Property(t => t.Comment2).HasColumnName("Comment2");
            this.Property(t => t.Comment3).HasColumnName("Comment3");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ActionComment)
                .WithMany(t => t.FurtherActionComments)
                .HasForeignKey(d => d.ActionCommentId);

        }
    }
}
