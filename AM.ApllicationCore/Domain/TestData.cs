using AM.ApllicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
  public static class TestData
    {
        public static Plane p1 = new Plane
        {
            Capacity = 150,
            PlaneType = PlaneType.Boing,
            ManuFactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane p2 = new Plane
        {
            Capacity = 250,
            PlaneType = PlaneType.Airbus,
            ManuFactureDate = new DateTime(2020, 11, 11)
        };
        public static Staff S1 = new Staff
        {FullName =new FullName
        {
            FirstName = "captain",
            LastName = "captain"
        },
            EmailAddress = "captain.captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            
           EmployementDate= new DateTime(1999, 01, 01),
            Salary = 99999

           

        };
        public static Staff S2 = new Staff
        {
            FullName = new FullName
            {
                FirstName = "captain",
                LastName = "captain"
            },
            EmailAddress = "hotess1.hotess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
          EmployementDate= new DateTime(2020, 01, 01),
            Salary = 999



        };
        public static Staff S3 = new Staff
        {
            FullName = new FullName
            {
                FirstName = "captain",
                LastName = "captain"
            },
            EmailAddress = "hotess2.hotess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
           EmployementDate= new DateTime(2020, 01, 01),
            Salary = 999



        };
        public static Traveller TR1 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "captain",
                LastName = "captain"
            },
            EmailAddress = "Traveller1.Traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation="NO  TROUBLES", 
            Nationality="American" ,

            



        };
        public static Traveller TR2 = new Traveller
        {FullName = new FullName
        {
            FirstName = "Traveller2",
            LastName = "Traveller2"
        },
            EmailAddress = "Traveller2.Traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "NO  TROUBLES",
            Nationality = "French",





        };
        public static Traveller TR3 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "Traveller3",
                LastName = "Traveller3"
            },
            EmailAddress = "Traveller3.Traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "Some  TROUBLES",
            Nationality = "Tunisian",





        };
        public static Traveller TR4 = new Traveller
        {
            FullName = new FullName
            {
                FirstName = "Traveller4",
                LastName = "Traveller4"
            },
            EmailAddress = "Traveller4.Traveller4@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some  TROUBLES",
            Nationality = "American",

        };
        public static Traveller TR5= new Traveller
        {
            FullName = new FullName
            {
                FirstName = "Traveller5",
                LastName = "Traveller5"
            },
            EmailAddress = "Traveller5.Traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some  TROUBLES",
            Nationality = "Spanich",
        };
        public static Flight F1 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p2,
            EstimatedDuration = 110,
          //  PassengersList = new List<Passenger>() { TR1, TR5, TR2, TR4, TR3  },


        };
        public static Flight F2 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p2,
            EstimatedDuration =110,


        };
        public static Flight F3 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p2,
            EstimatedDuration = 110,


        };
        public static Flight F4 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p2,
            EstimatedDuration = 105,


        };
        public static Flight F5 = new Flight
        {
            FlightDate = new DateTime(2022, 01, 01),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 05, 01),
            MyPlane = p2,
            EstimatedDuration = 105,
           


        };
        public static Flight F6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 01, 01),
            MyPlane = p1,
            EstimatedDuration = 200,

             
        };

        public static List<Flight> listFlights = new List<Flight>
            {F1,F2,F3,F4,F5,F6

        };


        




    }
}
