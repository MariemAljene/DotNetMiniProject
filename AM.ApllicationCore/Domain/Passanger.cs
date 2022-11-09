using AM.ApllicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        // public int Id { get; set; } // ou PassangerId 
        [Display(Name ="DateOfBirth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]
        public string PasseportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        // fULL NAME 
        public FullName FullName { get; set; }  

        [RegularExpression(@"^[0-9]{8}$")] 
        public string TelNumber { get; set; }
        //public ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return "Passenger : FirstName=" + FullName.FirstName + "LastName=" + FullName.LastName + "BirthDate=" + BirthDate +
                "TelNumber=" + TelNumber + "EmailAddress=" + EmailAddress + "Passeport Number=" + "\n";
        }

        /* public bool CheckProfil(String firstname,string lastname)
         {
             return  FirstName==firstname && LastName==lastname;
         }
         public bool CheckProfil(String firstname, string lastname,string emailadress )
         {
             return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;
         }*/
        public bool CheckProfil(String firstname, string lastname, string emailadress = null)
        {
            if (emailadress == null)
            {
                return FullName.FirstName == firstname && FullName.LastName == lastname;

            }
            else
            {
                return FullName.FirstName == firstname && FullName.LastName == lastname && EmailAddress == emailadress;

            }
        }
        public virtual void PassangerType()
        {

            Console.WriteLine("I am a passanger");
        }


    }
}
