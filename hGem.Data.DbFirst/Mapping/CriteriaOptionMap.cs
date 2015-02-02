using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CriteriaOptionMap : EntityTypeConfiguration<CriteriaOption>
    {
        public CriteriaOptionMap()
        {
            // Primary Key
            HasKey(t => t.CriteriaOptionId);

            // Properties
            Property(t => t.CriteriaOptionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.FieldAddress)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Id)
                .HasMaxLength(200);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("CriteriaOption");
            Property(t => t.CriteriaOptionId).HasColumnName("CriteriaOptionID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.FieldAddress).HasColumnName("FieldAddress");
            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Search).HasColumnName("Search");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
