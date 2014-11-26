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
            this.HasKey(t => t.PersonCallBackRequestId);

            // Properties
            this.Property(t => t.PersonCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonCallBackRequest");
            this.Property(t => t.PersonCallBackRequestId).HasColumnName("PersonCallBackRequestID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.PersonCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
