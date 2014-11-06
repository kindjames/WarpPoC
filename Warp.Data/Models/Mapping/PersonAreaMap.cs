using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonAreaMap : EntityTypeConfiguration<PersonArea>
    {
        public PersonAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonAreaID);

            // Properties
            this.Property(t => t.PersonAreaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonArea");
            this.Property(t => t.PersonAreaID).HasColumnName("PersonAreaID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.AreaID);

        }
    }
}
