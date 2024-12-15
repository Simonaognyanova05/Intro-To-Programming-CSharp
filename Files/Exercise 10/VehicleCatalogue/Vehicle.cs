using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Colour { get; set; } = null!;
        public double HorsePower { get; set; }
    }
}
