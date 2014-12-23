using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionPriorityMap : EntityTypeConfiguration<ActionPriority>
    {
        public ActionPriorityMap()
        {
            // Primary Key
            HasKey(t => t.ActionPriorityId);

            // Properties
            Property(t => t.ActionPriorityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            ToTable("ActionPriority");
            Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.WorkingDays).HasColumnName("WorkingDays");
            Property(t => t.Hours).HasColumnName("Hours");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
