using CountryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public interface IVoucherDiscountService
    {
        int GetVoucherDiscount(string voucher);

        List<Voucher> GetAllVouchers();


    }
 
}
