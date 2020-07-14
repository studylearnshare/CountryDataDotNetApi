using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryData.Models;
using CountryData.StaticData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoucherDiscountController : ControllerBase
    {
        private readonly IVoucherDiscountService _voucherDicount;

        public VoucherDiscountController(IVoucherDiscountService voucherDiscount )
        {
            _voucherDicount = voucherDiscount;
        }
        [HttpGet]
        public string Index()
        {
            return $"/VoucherDiscount/ - Help {Environment.NewLine}/VoucherDiscount/all - All available vouchers along with discount{Environment.NewLine}/VoucherDiscount/code - Discount for given voucher code";
        }
        // GET: /<controller>/
        [HttpGet]
        [Route("all")]
        public List<Voucher> GetAllVouchers()
        {
            return _voucherDicount.GetAllVouchers();
        }


        [Route("{voucher}")]
        public int GetVoucherDiscount(string voucher)
        {
            return _voucherDicount.GetVoucherDiscount(voucher);
        }
    }
}
