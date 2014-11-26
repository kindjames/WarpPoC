using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonBranchMap : EntityTypeConfiguration<PersonBranch>
    {
        public PersonBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBranchId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBranch", "Client");
            this.Property(t => t.PersonBranchId).HasColumnName("PersonBranchID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.BranchId);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PermissionTypeId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
