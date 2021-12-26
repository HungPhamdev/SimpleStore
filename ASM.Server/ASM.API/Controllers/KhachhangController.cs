using ASM.Share.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private readonly IKhachhangSvc _khachhangSvc;
        public KhachhangController(IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
        }

        // [Route("api/[controller]/{id}")]

        [HttpGet]
        public async Task<ActionResult<Khachhang>> GetKhachhang([FromQuery] int id)
        {
            return await _khachhangSvc.GetKhachhangAsync(id);
        }

        // POST api/Khachhang
        // To protect fcrom overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<int>> PostKhachhang(Khachhang khachhang)
        {
            try
            {
                int id = await _khachhangSvc.AddKhachhangRegisterAsync(khachhang);
                khachhang.KhachhangID = id;
            }
            catch(Exception ex)
            {
                // return BadRequest(-1);
            }
            return Ok(1);
        }

        // PUT api/Khachhang
        // To protect fcrom overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<ActionResult<int>> UpdateKhachhang(int id, Khachhang khachhang)
        {
            try
            {
                await _khachhangSvc.EditKhachhangAsync(id, khachhang);
            }
            catch (Exception ex)
            {
                // return BadRequest(-1);
            }
            return Ok(1);
        }
    }
}
