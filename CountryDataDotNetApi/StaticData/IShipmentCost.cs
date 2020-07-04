using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public interface IShipmentCost
    {
        decimal GetCountryShippingCost(string country);

    }
}
