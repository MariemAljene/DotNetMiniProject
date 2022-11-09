// See https://aka.ms/new-console-template for more information
using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Service;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

/*Plane plane1 = new Plane();
plane1.PlaneId = 1;
plane1.Capacity = 300;
plane1.ManufactureDate = new DateTime(2022,09,23);
plane1.PlaneType = PlaneType.Airbus;
Console.WriteLine(plane1.ToString());
Plane plane2 = new Plane(PlaneType.Airbus,500,DateTime.Now);
Console.WriteLine(plane2.ToString());*/
Plane p3 = new Plane()
{ Capacity = 500, PlaneType = PlaneType.Airbus, ManuFactureDate = DateTime.Now };
Console.WriteLine(p3.ToString());
Passenger pass1 = new Passenger
{FullName = new FullName
{
    FirstName = "mariem",
    LastName = "aljene"
},
    EmailAddress = "mariem.aljene@esprit.tn"


};
Console.WriteLine("AVANT");
Console.WriteLine(pass1.ToString());
pass1.UpperFullName();
Console.WriteLine("APRES");
Console.WriteLine(pass1.ToString());
Console.WriteLine(pass1.CheckProfil("mariem", "aljene"));
pass1.PassangerType();
Staff stf = new Staff();
stf.PassangerType();
ServiceFlight sf = new ServiceFlight(); 
sf.Flights = TestData.listFlights; 
foreach(var flight in sf.getFlightDatesForEach("Paris"))
{
    Console.WriteLine("Les dates sont");
    Console.WriteLine(flight);

};
foreach (var flight in sf.getFlightDates2("Paris"))
{
    Console.WriteLine("Les dates sont");
    Console.WriteLine(flight);

};
Console.WriteLine("GetFlightFiltré");
sf.GetFlights("Destination","Paris") ;
Console.WriteLine("Details de l'avion");
sf.ShowFlifhtDetails(TestData.p2);
Console.WriteLine(sf.DurationAverage("Madrid"));
Console.WriteLine("Les vols ordonnés :");
foreach (var flight in sf.OrderedDurationFlights())
{
    
    Console.WriteLine(flight);
}
Console.WriteLine("Les Top 3 Travellers");

/*foreach (var f in sf.SeniorTravellers(TestData.F1))
{
    Console.WriteLine(f);
}*/
Console.WriteLine("Les vols par Destination  :");

sf.DestinationGroupedFlights();
Console.WriteLine(sf.DurationAverageDel("Paris"));
sf.FlightDetailsDel(TestData.p1);

AMContext context = new AMContext();
/*context.Flights.Add(TestData.F3);
context.SaveChanges();*/
Console.WriteLine("Test");
Console.WriteLine(context.Flights.First().MyPlane.Capacity) ;



