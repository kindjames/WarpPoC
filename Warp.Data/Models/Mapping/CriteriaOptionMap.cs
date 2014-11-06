using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CriteriaOptionMap : EntityTypeConfiguration<CriteriaOption>
    {
        public CriteriaOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.CriteriaOptionID);

            // Properties
            this.Property(t => t.CriteriaOptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FieldAddress)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ID)
                .HasMaxLength(200);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CriteriaOption");
            this.Property(t => t.CriteriaOptionID).HasColumnName("CriteriaOptionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FieldAddress).HasColumnName("FieldAddress");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Search).HasColumnName("Search");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
