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
            this.HasKey(t => t.CriteriaOptionId);

            // Properties
            this.Property(t => t.CriteriaOptionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FieldAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Id)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CriteriaOption");
            this.Property(t => t.CriteriaOptionId).HasColumnName("CriteriaOptionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FieldAddress).HasColumnName("FieldAddress");
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Search).HasColumnName("Search");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
