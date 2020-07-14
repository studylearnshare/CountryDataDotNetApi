using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.Models
{
    public class Voucher
    {
        public string VoucherCode { get; internal set; }

        public int Discount { get; internal set; }
    }
}
