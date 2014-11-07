using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ActionMap : EntityTypeConfiguration<Action>
    {
        public ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionID);

            // Properties
            this.Property(t => t.ActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Action");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.AddedUser).HasColumnName("AddedUser");
            this.Property(t => t.ActionPriorityID).HasColumnName("ActionPriorityID");
            this.Property(t => t.ActionTypeID).HasColumnName("ActionTypeID");
            this.Property(t => t.ActionStatusID).HasColumnName("ActionStatusID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.AddedUser);
            this.HasRequired(t => t.ActionPriority)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionPriorityID);
            this.HasRequired(t => t.ActionStatu)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionStatusID);
            this.HasRequired(t => t.ActionType)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionTypeID);

        }
    }
}
