using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Customers
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Vechicle_Number { get; set; }
        public string Vechicle_Type { get; set; }
        public string Email_Id{get; set;}
        public string Address { get; set; }
        public string Mobile_No { get; set; }
        public  string Policy_Id { get; set; }
        public int Insurance_Id { get; set; }

    }
}