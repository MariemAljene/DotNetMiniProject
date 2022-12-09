using AM.ApllicationCore.Domain;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//base DE donnée
        {
           optionsBuilder.UseLazyLoadingProxies();//pour pouvoir acceder FLight.Capacity par exemple et apres rendre virtual les prop de navigation
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=MariemAljeneDB;Integrated Security=true;MultipleActiveResultSets=true") ;
            base.OnConfiguring(optionsBuilder);

        } 

        public DbSet<Plane> Planes { get; set; }//ON PEUT DECLARER UNE SEULE CLASSE et les autres qui ont une relation avec il va les deteclter sinon 
        //si table mtaysha sans relation il faut la declarer 
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> Travellers { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelbuilder)//APPEL DE LA CLASSE DE CONFIGURATION 
        {
            modelbuilder.ApplyConfiguration(new PlaneConfiguration());
            modelbuilder.ApplyConfiguration(new FlightConfiguration());
            modelbuilder.ApplyConfiguration(new PassangerConfiguration());
            modelbuilder.Entity<Staff>().ToTable("Staff");//TPT
            modelbuilder.Entity<Traveller>().ToTable("Traveller");//TPT
            modelbuilder.ApplyConfiguration(new TicketConfiguration());

        }  
        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfiguration)
        {
            modelConfiguration.Properties<DateTime>().HaveColumnType("date");
            //preconvention 
            //conventionParDefaut<preconvention<annotations<ConventionFluentAPi
            //                     ENSELMBLE DE PROP< 1seule< 1 CLASSE
        }  





    }
}
