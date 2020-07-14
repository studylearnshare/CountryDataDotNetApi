using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.Models
{
    public class Shipment
    {
        public string Country { get;  internal set; }

        public decimal Cost { get; internal set; }
    }
}
