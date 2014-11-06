using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorLevelMap : EntityTypeConfiguration<AssessorLevel>
    {
        public AssessorLevelMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorLevelID);

            // Properties
            this.Property(t => t.AssessorLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AssessorLevel");
            this.Property(t => t.AssessorLevelID).HasColumnName("AssessorLevelID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
