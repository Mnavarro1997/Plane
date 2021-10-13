using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingVueling.Models
{
    internal class Plane
    {
        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int FabricationYear { get; set; }

        public int Revision { get; set; }

        public int AerolineId { get; set; }
    }
}