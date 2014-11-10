using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonBranchMap : EntityTypeConfiguration<PersonBranch>
    {
        public PersonBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBranchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBranch", "Client");
            this.Property(t => t.PersonBranchID).HasColumnName("PersonBranchID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PermissionTypeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
