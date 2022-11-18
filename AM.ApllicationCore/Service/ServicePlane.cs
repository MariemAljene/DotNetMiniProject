using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interface;
using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Service
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
       // IGenericRepository<Plane> genericRepository; 
      // IUnitOfWork _unitOfWork;
        public ServicePlane( IUnitOfWork unitOfWork):base (unitOfWork)
        {
            // this.genericRepository = genericRepository; 
         //_unitOfWork = unitOfWork;

        }

        public void DeletePlanes()
        {
            Delete (p => DateTime.Now.Year - p.ManuFactureDate.Year>10) ;
        }

        public IEnumerable<Flight> GetFlights(int n)
        {
            return GetAll()
                   .OrderByDescending(P => P.PlaneId)
                   .Take(n)
                   .SelectMany(p=>p.Flights)
                   .OrderBy(f=>f.Departure);

        }

        public IEnumerable<Passenger> GetPassenger(Plane p)
        {
            return GetById(p.PlaneId)
                                     .Flights.SelectMany(f => f.Tickets)
                                     .Select(t => t.MyPassanger);
        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            
            int capacity = Get(p => p.Flights.Contains(flight) == true).Capacity; 
            int nbTicket=flight.Tickets.Count;
             return capacity>=nbTicket+n;
        }
        /* public void Add(Plane P)
{
    _unitOfWork.Repository<Plane>().Add(P);
}

public IEnumerable<Plane> GetAll()
{
   return _unitOfWork.Repository<Plane>().GetAll();
}

public void Remove(Plane P)
{
    _unitOfWork.Repository<Plane>().Delete(P) ;
}*/
    }
}
