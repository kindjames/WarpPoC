using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressBranchMap : EntityTypeConfiguration<ContactAddressBranch>
    {
        public ContactAddressBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressBranchId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressBranch", "Client");
            this.Property(t => t.ContactAddressBranchId).HasColumnName("ContactAddressBranchID");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.AssignedByAdminId).HasColumnName("AssignedByAdminId");

            // Relationships
            this.HasRequired(t => t.Branch)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.BranchId);

            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressId);

            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBranches)
                .HasForeignKey(d => d.ContactAddressTypeId);
        }
    }
}
