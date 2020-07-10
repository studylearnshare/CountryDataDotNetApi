using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public interface IVoucherDiscount
    {
        int GetVoucherDiscount(string voucher);

    }
}
