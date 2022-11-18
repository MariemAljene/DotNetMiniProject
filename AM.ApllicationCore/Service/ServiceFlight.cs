using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interface;
using AM.ApllicationCore.Service;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Plane = AM.ApllicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServicesFlight
    {
        public Action<Plane> FlightDetailsDel; 
        public Func <string,double> DurationAverageDel;
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public IList<DateTime> getFlightDates(string destination)
        { List<DateTime> dates = new List<DateTime>();    
            for (int i = 0; i < Flights.Count; i++)
            {if (Flights[i].Destination.Equals(destination))
                    {
                    dates.Add(Flights[i].FlightDate);
                }
             
            }
            return dates;

        }
        public IList<DateTime> getFlightDatesForEach(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach(Flight flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    dates.Add(flight.FlightDate);
                }

            }
            return dates;

        }
        public IList<DateTime> getFlightDates2(string destination)
        { /*var query=from f in Flights
                where   f.Destination==destination  
                    select f.FlightDate;
            return query.ToList();*/
            var reqLambda = Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.FlightDate);
            return reqLambda.ToList();
        }
        public void GetFlights(String filterType ,string filterValue)
        {
            switch(filterType)
                {
                case "Destination": 
                    foreach(Flight flight in Flights)
                    {
                        if(flight.Destination.Equals(filterValue))
                            {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Date":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate.Equals(DateTime.Parse(filterValue)))
                        {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Duration":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration.Equals(int.Parse(filterValue)))
                        {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;

            }

        }

        public void ShowFlifhtDetails(Plane plane)
        {/*
           var req=from flight in Flights
                   where flight.MyPlane==plane
                   select flight;   
            */
            var req = Flights
                .Where(f => f.MyPlane == plane);
             // OPTIONAL  .Select(f=>f) ;
            foreach(var flight in req)
            {
                Console.WriteLine(flight.FlightDate + "" + flight.Destination);
            }

        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {

            /*  var req = from f in Flights
                        where (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays > 0
                        select f;
              return req.Count(); 
            */
            return( Flights
                  .Where(f => (f.FlightDate - startDate).TotalDays < 7 && (f.FlightDate - startDate).TotalDays > 0)
                  .Select(f => f)).Count(); 
            
        }


public double DurationAverage(string destination)
        {/*
            var req = from f in Flights
                      where (f.Destination == destination)
                      select f.EstimatedDuration;*/
            return (Flights
                .Where(f => f.Destination == destination)
                .Select(f => f.EstimatedDuration)).Average();
               
        }
        public IList<Flight> OrderedDurationFlights()
        {
            /*var req = from f in Flights
                      orderby f.EstimatedDuration descending
                      select f;*/
            return Flights
                .OrderByDescending(f => f.EstimatedDuration)
                .ToList();
            
        }

       /* public IList<Traveller> SeniorTravellers(Flight flight)
        {
            /* var req = from p in flight.PassengersList.OfType<Traveller>()
                       orderby p.BirthDate 
                       select p;
             return req.Take(3).ToList();
            return (flight.PassengersList.OfType<Traveller>()
                .OrderBy(p => p.BirthDate)
                .Take(3).ToList());
        }*/

        public void DestinationGroupedFlights()
        {
            /*  var req = from f in Flights
                        group f by f.Destination;*/
            var req = Flights.GroupBy(f => f.Destination);
                    foreach (var g in req)
            {
                Console.WriteLine("Destination "+g.Key ); 
                foreach(var  f in g )
                {
                    Console.WriteLine("Decollage : " + f.FlightDate);
                }

            }
                     

         }
        //IGenericRepository<Flight> genericRepository; 
        IUnitOfWork _unitOfWork;
        public ServiceFlight(IUnitOfWork unitOfWork ): base(unitOfWork)
        {
           _unitOfWork=unitOfWork;

        }
       /* public void Add(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Add(flight);
        }

        public void Remove(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Delete(flight);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _unitOfWork.Repository<Flight>().GetAll();
        }*/

       /* public ServiceFlight()
        {
            FlightDetailsDel = ShowFlifhtDetails;
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = p =>
            {
                var req = from flight in Flights
                          where flight.MyPlane == p
                          select flight;
                foreach (var flight in req)
                {
                    Console.WriteLine(flight.FlightDate + "" + flight.Destination);
                }

            };
            DurationAverageDel = d =>
            {
                var req = from f in Flights
                          where (f.Destination == d)
                          select f.EstimatedDuration;
                return req.Average();
            };

        }*/


    }
    }
  

