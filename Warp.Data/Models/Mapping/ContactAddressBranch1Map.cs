using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressBranch1Map : EntityTypeConfiguration<ContactAddressBranch1>
    {
        public ContactAddressBranch1Map()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressBranchID);

            // Properties
            this.Property(t => t.ContactAddressBranchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ContactAddressBranch");
            this.Property(t => t.ContactAddressBranchID).HasColumnName("ContactAddressBranchID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Branch1)
                .WithMany(t => t.ContactAddressBranch1)
                .HasForeignKey(d => d.BranchID);
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBranch1)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBranch1)
                .HasForeignKey(d => d.ContactAddressTypeID);

        }
    }
}
