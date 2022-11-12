using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public class Ticket
    {
        public double Prix { get; set; } 
        public int Siege { get; set; }
        public bool VIP { get; set; }
       // [ForeignKey("MyFlight")] ou 
        public int FlightFK { get; set; }
       // [ForeignKey("MyPassanger")]  ou
        public string PassangerFK { get; set; }
        [ForeignKey("PassangerFK")]//SI ON APPELLE PassangerId pas besoin de faire annotation il comprend tt seule que c est une forgein Key 
        public virtual Passenger MyPassanger { get; set; }
        [ForeignKey("FlightFK")]
        public virtual Flight MyFlight { get; set; }

    }
}
