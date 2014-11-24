using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ActionCommentMap : EntityTypeConfiguration<ActionComment>
    {
        public ActionCommentMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionCommentId);

            // Properties
            this.Property(t => t.ActionCommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ActionComment");
            this.Property(t => t.ActionCommentId).HasColumnName("ActionCommentID");
            this.Property(t => t.ActionId).HasColumnName("ActionID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            this.Property(t => t.ActionTypeId).HasColumnName("ActionTypeID");
            this.Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.Action)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionId);
            this.HasRequired(t => t.ActionStatu)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionStatusId);

        }
    }
}
