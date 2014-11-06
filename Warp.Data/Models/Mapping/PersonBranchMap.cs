using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonBranchMap : EntityTypeConfiguration<PersonBranch>
    {
        public PersonBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBranchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBranch");
            this.Property(t => t.PersonBranchID).HasColumnName("PersonBranchID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.PersonBranches)
                .HasForeignKey(d => d.BranchID);

        }
    }
}
