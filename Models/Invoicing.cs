using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingVueling.Models
{
    internal class Invoicing
    {
        public string LicensePlate { get; set; }
        public string PassengerDNI { get; set; }
        public DateTime FliyingDate { get; set; }
        public decimal Cost { get; set; }
    }
}