using AM.ApllicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.PassangerFK, t.FlightFK });//Clé primaire composée 
            builder.HasOne(t => t.MyFlight)
                    .WithMany(f => f.Tickets)
                    .HasForeignKey(t=>t.FlightFK);
            builder.HasOne(t => t.MyPassanger)
                   .WithMany(p => p.Tickets)
                   .HasForeignKey(t => t.PassangerFK);
        }
    }
}
