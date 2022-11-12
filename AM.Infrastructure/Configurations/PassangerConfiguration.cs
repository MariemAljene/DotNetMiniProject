using AM.ApllicationCore.Domain;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PassangerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName, full =>// FULLNAME DETENUE obligatoire  7ata FUllNAME OBLIGATOIRE SINON enty wel ex 
            {
                full.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                full.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
            }
            );
           /* builder.HasDiscriminator<string>("IsTraveller") strategie TPH
                   .HasValue<Traveller>("1")
                   .HasValue<Staff>("2")
                   .HasValue<Passenger>("0");
           */
                                                             
        }  

       
    }
}
