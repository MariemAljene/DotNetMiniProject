using AM.ApllicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        [ForeignKey("PlaneId")] 
        public virtual Plane MyPlane { get; set; }
        public string? Airline { get; set; }
        //[ForeignKey("MyPlane")]
        public int PlaneId { get; set; } 
        public virtual ICollection<Ticket> Tickets { get; set; }
       // public ICollection<Passenger> PassengersList { get; set; }
        
        public override string ToString()
        {
            return "Flight : Flight Id=" + FlightId + "Destination=" + Destination + "Departure=" + Departure +
                   "Flight Date=" + FlightDate + "Effective Arrival" + EffectiveArrival + "Estimated Duration" + EstimatedDuration;
                 //  "Plane" + MyPlane + "Passengers List" + PassengersList + "\n";
        }
    }
}
