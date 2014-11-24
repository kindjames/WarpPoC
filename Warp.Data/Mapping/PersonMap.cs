using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonId);

            // Properties
            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person", "Client");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.PersonStatusId).HasColumnName("PersonStatusID");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.UserRoleId);
            this.HasRequired(t => t.Client)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.PersonStatu)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.PersonStatusId);

        }
    }
}
