using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonCallBackRequestMap : EntityTypeConfiguration<PersonCallBackRequest>
    {
        public PersonCallBackRequestMap()
        {
            // Primary Key
            HasKey(t => t.PersonCallBackRequestId);

            // Properties
            Property(t => t.PersonCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("PersonCallBackRequest");
            Property(t => t.PersonCallBackRequestId).HasColumnName("PersonCallBackRequestID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.PersonCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
