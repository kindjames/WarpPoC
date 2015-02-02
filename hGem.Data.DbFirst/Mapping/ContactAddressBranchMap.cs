using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressBranchMap : EntityTypeConfiguration<ContactAddressBranch>
    {
        public ContactAddressBranchMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressBranchId);

            // Properties
            // Table & Column Mappings
            ToTable("ContactAddressBranch", "Client");
            Property(t => t.ContactAddressBranchId).HasColumnName("ContactAddressBranchID");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.AssignedByAdminId).HasColumnName("AssignedByAdminId");

            // Relationships
            HasRequired(t => t.Branch)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.BranchId);

            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressId);

            HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressTypeId);
        }
    }
}
