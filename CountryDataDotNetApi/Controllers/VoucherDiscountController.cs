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
        private readonly IVoucherDiscount _voucherDicount;

        public VoucherDiscountController(IVoucherDiscount voucherDiscount )
        {
            _voucherDicount = voucherDiscount;
        }
        [HttpGet]
        public string Index()
        {
            return "Service working!";
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
