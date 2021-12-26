using ASM.Share.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DonhangController : ControllerBase
    {
        private readonly IDonhangSvc _donhangSvc;
        public DonhangController(IDonhangSvc donhangSvc)
        {
            _donhangSvc = donhangSvc;
        }

        //[Route("api/[controller]/{id}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donhang>>> GetDonhangbyKhachhang([FromQuery]int id)
        {
            return await _donhangSvc.GetDonhangbyKhachhangAsync(id);
        }

    }
}
