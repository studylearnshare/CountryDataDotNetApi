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
    public class TaxController : ControllerBase
    {
        private readonly ICountryTax _countryTax;

        public TaxController(ICountryTax countryTax)
        {
            _countryTax = countryTax;
        }

        // GET: /<controller>/
        [HttpGet]
        public string Index()
        {
            return "Service working!";
        }

        [Route("country/{country}/amount/{amount}")]
        public float GetCountryTax(string country, decimal amount)
        {
            return _countryTax.GetCountryTax(country.ToLower(),amount);
        }
    }
}
