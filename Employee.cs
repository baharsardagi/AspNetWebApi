using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApiDemo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Age { get; set; }
    }
}