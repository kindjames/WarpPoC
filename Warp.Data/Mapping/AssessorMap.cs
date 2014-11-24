using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorMap : EntityTypeConfiguration<Assessor>
    {
        public AssessorMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorId);

            // Properties
            this.Property(t => t.HomeTelephone)
                .HasMaxLength(50);

            this.Property(t => t.WorkTelephone)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.BankName)
                .HasMaxLength(50);

            this.Property(t => t.BankAddress)
                .HasMaxLength(100);

            this.Property(t => t.SortCode)
                .HasMaxLength(10);

            this.Property(t => t.AccountNumber)
                .HasMaxLength(50);

            this.Property(t => t.Occupation)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Assessor");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            this.Property(t => t.AssessorLevelId).HasColumnName("AssessorLevelID");
            this.Property(t => t.AssessorLevelLock).HasColumnName("AssessorLevelLock");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.HomeTelephone).HasColumnName("HomeTelephone");
            this.Property(t => t.WorkTelephone).HasColumnName("WorkTelephone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.BankAddress).HasColumnName("BankAddress");
            this.Property(t => t.SortCode).HasColumnName("SortCode");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.GenderId).HasColumnName("GenderID");
            this.Property(t => t.DateOfLastProfileUpdate).HasColumnName("DateOfLastProfileUpdate");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
