using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionTypeMap : EntityTypeConfiguration<ActionType>
    {
        public ActionTypeMap()
        {
            // Primary Key
            HasKey(t => t.ActionTypeId);

            // Properties
            Property(t => t.ActionTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ActionType");
            Property(t => t.ActionTypeId).HasColumnName("ActionTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
