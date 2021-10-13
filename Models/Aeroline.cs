using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingVueling.Models
{
    internal class Aeroline
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CreationYear { get; set; }

        public decimal AvgAnnualInvoicing { get; set; }
    }
}