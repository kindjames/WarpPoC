using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class NoteTypeMap : EntityTypeConfiguration<NoteType>
    {
        public NoteTypeMap()
        {
            // Primary Key
            HasKey(t => t.NoteTypeId);

            // Properties
            Property(t => t.NoteTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("NoteType");
            Property(t => t.NoteTypeId).HasColumnName("NoteTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
