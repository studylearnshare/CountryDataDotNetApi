using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CountryData.StaticData;
using CountryData.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CountryData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipmentCostController : ControllerBase
    {
        private IShipmentCost _countryShippingCost;

        public ShipmentCostController(IShipmentCost countryCostInfo)
        {
            _countryShippingCost = countryCostInfo;
        }
        // GET: /<controller>/

        [HttpGet]
        public string Index()
        {
            return $"/ShipmentCost/ - Help {Environment.NewLine}/ShipmentCost/all - Shipment cost for all countries{Environment.NewLine}/ShipmentCost/country - Shipment cost for given country";
        }

        [HttpGet]
        [Route("all")]
        public List<Shipment> GetAllCountriesShipmentCost()
        {
            return _countryShippingCost.GetAllCountriesShipmentCost();
        }

        [Route("{country}")]
        public decimal GetCountryShipmentCost(string country)
        {
            return _countryShippingCost.GetCountryShippingCost(country.ToLower());
        }
    }
}
