using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSOLIDPrinciples.SRP.Models
{
   public  class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
    }
}
