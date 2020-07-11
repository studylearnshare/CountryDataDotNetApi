using CountryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public interface ICountryTax
    {
        float GetCountryTax(string country, decimal amount);

        List<Tax> GetAllCountriesWithTax();

    }
}
