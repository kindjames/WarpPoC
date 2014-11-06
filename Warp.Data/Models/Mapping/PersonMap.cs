using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonID);

            // Properties
            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person", "Client");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.PersonStatusID).HasColumnName("PersonStatusID");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.PersonStatu)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.PersonStatusID);
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.UserRoleID);

        }
    }
}
