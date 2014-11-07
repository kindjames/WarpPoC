using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ActionCommentMap : EntityTypeConfiguration<ActionComment>
    {
        public ActionCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionCommentID);

            // Properties
            this.Property(t => t.ActionCommentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ActionComment");
            this.Property(t => t.ActionCommentID).HasColumnName("ActionCommentID");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ActionPriorityID).HasColumnName("ActionPriorityID");
            this.Property(t => t.ActionTypeID).HasColumnName("ActionTypeID");
            this.Property(t => t.ActionStatusID).HasColumnName("ActionStatusID");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Action)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionID);
            this.HasRequired(t => t.ActionStatu)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionStatusID);

        }
    }
}
