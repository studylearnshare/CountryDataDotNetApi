using CountryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryData.StaticData
{
    public class VoucherDiscountService : IVoucherDiscountService
    {
        public readonly List<Voucher> _vouchers = new List<Voucher>();

        public VoucherDiscountService()
        {
            _vouchers.Add(new Voucher{ VoucherCode = "AXZ123",  Discount = 10});
            _vouchers.Add(new Voucher { VoucherCode = "QAZ234", Discount = 5 });
            _vouchers.Add(new Voucher { VoucherCode = "PLM321", Discount = 15 });

        }

        public List<Voucher> GetAllVouchers()
        {
            return _vouchers;
        }

        public int GetVoucherDiscount(string voucher)
        {
            var discount = _vouchers.Where(x => x.VoucherCode == voucher).Select(s => s.Discount).FirstOrDefault();
            return discount;
        }
    }
}
