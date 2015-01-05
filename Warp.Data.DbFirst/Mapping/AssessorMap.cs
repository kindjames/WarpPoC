using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorMap : EntityTypeConfiguration<Assessor>
    {
        public AssessorMap()
        {
            // Primary Key
            HasKey(t => t.AssessorId);

            // Properties
            Property(t => t.HomeTelephone)
                .HasMaxLength(50);

            Property(t => t.WorkTelephone)
                .HasMaxLength(50);

            Property(t => t.Mobile)
                .HasMaxLength(50);

            Property(t => t.Fax)
                .HasMaxLength(50);

            Property(t => t.BankName)
                .HasMaxLength(50);

            Property(t => t.BankAddress)
                .HasMaxLength(100);

            Property(t => t.SortCode)
                .HasMaxLength(10);

            Property(t => t.AccountNumber)
                .HasMaxLength(50);

            Property(t => t.Occupation)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Assessor");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.AssessorStatusId).HasColumnName("AssessorStatusID");
            Property(t => t.AssessorLevelId).HasColumnName("AssessorLevelID");
            Property(t => t.AssessorLevelLock).HasColumnName("AssessorLevelLock");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            Property(t => t.HomeTelephone).HasColumnName("HomeTelephone");
            Property(t => t.WorkTelephone).HasColumnName("WorkTelephone");
            Property(t => t.Mobile).HasColumnName("Mobile");
            Property(t => t.Fax).HasColumnName("Fax");
            Property(t => t.BankName).HasColumnName("BankName");
            Property(t => t.BankAddress).HasColumnName("BankAddress");
            Property(t => t.SortCode).HasColumnName("SortCode");
            Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            Property(t => t.Occupation).HasColumnName("Occupation");
            Property(t => t.GenderId).HasColumnName("GenderID");
            Property(t => t.DateOfLastProfileUpdate).HasColumnName("DateOfLastProfileUpdate");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
