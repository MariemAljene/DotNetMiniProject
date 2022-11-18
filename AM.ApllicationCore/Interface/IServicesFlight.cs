using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interface;
using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
   public interface IServicesFlight :IServices<Flight>
    {
        IList<DateTime> getFlightDates(string destination);
        void GetFlights(String filterType, string filterValue);
         IList<DateTime> getFlightDates2(string destination);
         void ShowFlifhtDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IList<Flight> OrderedDurationFlights();
        //  IList <Traveller> SeniorTravellers(Flight flight);
        void DestinationGroupedFlights(); 
       /* void Add(Flight flight);
        void Remove(Flight flight);
        IEnumerable<Flight> GetAll();*/

    }
}
