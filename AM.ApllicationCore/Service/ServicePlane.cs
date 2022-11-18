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
       IUnitOfWork _unitOfWork;
        public ServicePlane( IUnitOfWork unitOfWork):base (unitOfWork)
        {
            // this.genericRepository = genericRepository; 
            _unitOfWork = unitOfWork;

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
