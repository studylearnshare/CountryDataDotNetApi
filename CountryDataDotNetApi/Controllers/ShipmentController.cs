using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CountryData.StaticData;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CountryData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipmentController : ControllerBase
    {
        private IShipmentCost _countryShippingCost;

        public ShipmentController(IShipmentCost countryCostInfo)
        {
            _countryShippingCost = countryCostInfo;
        }
        // GET: /<controller>/
        
        [HttpGet]
        public string Index()
        {
            return "Service working!";
        }

        [Route("{country}")]
        public decimal GetCountryShipmentCost(string country)
        {
            return _countryShippingCost.GetCountryShippingCost(country.ToLower());
        }
    }
}
