using AM.ApllicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Interface
{
    public interface IServicePlane
    {
        void Add(Plane P); 
        void Remove(Plane P);
        IEnumerable<Plane> GetAll();

    }
}
