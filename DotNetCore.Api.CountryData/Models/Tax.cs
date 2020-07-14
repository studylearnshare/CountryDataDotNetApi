using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.Models
{
    public class Tax
    {
        public string Country { get; internal set; }

        public int VAT{ get; internal set; }
    }
}
