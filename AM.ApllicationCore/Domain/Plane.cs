using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        [Range (0,int.MaxValue)] //POSITIF
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManuFactureDate = date;
        }
        public Plane()
        {

        }


    }
}
