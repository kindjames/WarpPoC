using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressBranchMap : EntityTypeConfiguration<ContactAddressBranch>
    {
        public ContactAddressBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressBranchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressBranch", "Client");
            this.Property(t => t.ContactAddressBranchID).HasColumnName("ContactAddressBranchID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.AssignedByAdminId).HasColumnName("AssignedByAdminId");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressTypeID);

        }
    }
}
