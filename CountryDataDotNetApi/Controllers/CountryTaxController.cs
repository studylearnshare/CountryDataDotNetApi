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
    public class CountryTaxController : ControllerBase
    {
        private readonly ICountryTax _countryTax;

        public CountryTaxController(ICountryTax countryTax)
        {
            _countryTax = countryTax;
        }
        [HttpGet]
        public string Index()
        {
            return "Service working!";
        }
        // GET: /<controller>/
        [HttpGet]
        [Route("all")]
        public List<Tax> GetAllCountriesWithTax()
        {
            return _countryTax.GetAllCountriesWithTax();
        }

        [Route("{country}/{amount}")]
        public float GetCountryTax(string country, decimal amount)
        {
            return _countryTax.GetCountryTax(country.ToLower(),amount);
        }
    }
}
