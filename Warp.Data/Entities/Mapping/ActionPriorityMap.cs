using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ActionPriorityMap : EntityTypeConfiguration<ActionPriority>
    {
        public ActionPriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionPriorityID);

            // Properties
            this.Property(t => t.ActionPriorityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ActionPriority");
            this.Property(t => t.ActionPriorityID).HasColumnName("ActionPriorityID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.WorkingDays).HasColumnName("WorkingDays");
            this.Property(t => t.Hours).HasColumnName("Hours");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
