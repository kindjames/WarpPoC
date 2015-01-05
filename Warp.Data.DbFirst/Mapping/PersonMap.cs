using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            HasKey(t => t.PersonId);

            // Properties
            Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Person", "Client");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.PersonStatusId).HasColumnName("PersonStatusID");
            Property(t => t.JobTitle).HasColumnName("JobTitle");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.UserRoleId);
            HasRequired(t => t.Client)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.PersonStatus)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.PersonStatusId);

        }
    }
}
