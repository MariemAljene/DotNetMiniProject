using AM.ApllicationCore.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string? function { get; set; }
        [DataType(DataType.Currency)]
        public float Salary { get; set; }


        public override string ToString()
        {
            return "Staff :" + base.ToString() + "EmlpoyementDate=" + EmployementDate + "Function=" + function +
                   "Salary=" + Salary + "\n";
        }
        public override void PassangerType()
        {
            base.PassangerType();
            Console.WriteLine("I am a staff");
        }
    }
}
