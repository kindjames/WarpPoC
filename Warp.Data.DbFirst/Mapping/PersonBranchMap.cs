using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonBranchMap : EntityTypeConfiguration<PersonBranch>
    {
        public PersonBranchMap()
        {
            // Primary Key
            HasKey(t => t.PersonBranchId);

            // Properties
            // Table & Column Mappings
            ToTable("PersonBranch", "Client");
            Property(t => t.PersonBranchId).HasColumnName("PersonBranchID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.BranchId);
            HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PermissionTypeId);
            HasRequired(t => t.Person)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
