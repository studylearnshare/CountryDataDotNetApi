using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryData.StaticData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherDiscount _voucherDicount;

        public VoucherController(IVoucherDiscount voucherDiscount )
        {
            _voucherDicount = voucherDiscount;
        }
        // GET: /<controller>/
        [HttpGet]
        public string Index()
        {
            return "Service working!";
        }

        [Route("voucher/{voucher}")]
        public int GetVoucherDiscount(string voucher)
        {
            return _voucherDicount.GetVoucherDiscount(voucher);
        }
    }
}
