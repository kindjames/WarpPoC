using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionStatusMap : EntityTypeConfiguration<ActionStatus>
    {
        public ActionStatusMap()
        {
            // Primary Key
            HasKey(t => t.ActionStatusId);

            // Properties
            Property(t => t.ActionStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ActionStatus");
            Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.OpenStatus).HasColumnName("OpenStatus");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
