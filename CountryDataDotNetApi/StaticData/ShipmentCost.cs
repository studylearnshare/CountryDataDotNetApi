using CountryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public class ShipmentCost : IShipmentCost
    {
        public readonly List<Shipment> _countryCost = new List<Shipment>();

        public ShipmentCost()
        {
            _countryCost.Add(new Shipment { Country = "finland", Cost = 39 });
            _countryCost.Add(new Shipment { Country = "ireland", Cost = 25 });
            _countryCost.Add(new Shipment { Country = "india", Cost = 44 });
            _countryCost.Add(new Shipment { Country = "swden", Cost = 37 });
            _countryCost.Add(new Shipment { Country = "norway", Cost = 35 });
        }
        public decimal GetCountryShippingCost(string country)
        {
            return _countryCost.Where(x => x.Country == country).Select(s => s.Cost).FirstOrDefault();
        }
    }
}
