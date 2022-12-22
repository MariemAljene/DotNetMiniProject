using AM.ApllicationCore.Interface;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Am.Ui.Web.Controllers
{
    public class FlightController : Controller
    {
        IServicesFlight servicesFlight; 
        IServicePlane servicePlane;
        public FlightController(IServicesFlight servicesFlight,IServicePlane servicePlane)
        {
            this.servicesFlight = servicesFlight;  
            this.servicePlane = servicePlane;   
        }

        // GET: FlightController
        public ActionResult Index(DateTime? dateDepart)
        {
            if (dateDepart == null)
                return View(servicesFlight.GetAll());
            else
                return View(servicesFlight.GetMany(f => f.FlightDate.Date.Equals(dateDepart)));
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View(servicesFlight.GetById(id));
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.PlaneId = new SelectList(servicePlane.GetAll(), "PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection,IFormFile Airline)
        {
            try
            {
                if (Airline != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),

                    "wwwroot", "Uploads", Airline.FileName);

                    Stream stream = new FileStream(path, FileMode.Create);
                    Airline.CopyTo(stream);
                    collection.Airline = Airline.FileName;
                }

                servicesFlight.Add(collection);
                servicesFlight.Commit();
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(servicesFlight.GetById(id)); 

        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight collection)
        {
            try
            {
                servicesFlight.Update(collection);
                servicesFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(servicesFlight.GetById (id));
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Flight collection)
        {
            try
            {
                servicesFlight.Delete(collection);
                servicesFlight.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
