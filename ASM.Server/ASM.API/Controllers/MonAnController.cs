using ASM.Share.Models;
using ASM.Share.RequestFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private readonly IMonAnSvc _monAnSvc;
        public MonAnController(IMonAnSvc monAnSvc)
        {
            _monAnSvc = monAnSvc;
        }

        //GET: api/MonAn
        [HttpGet]
         public async Task<ActionResult<IEnumerable<MonAn>>> GetMonAnAll()
        {
            return await _monAnSvc.GetMonAnAllAsync();
        }

        [HttpGet("/api/paging")]
        public async Task<ActionResult<MonAnDTO>> GetMonAns([FromQuery] ProductParameters productParameters)
        {
            var prodObj = new MonAnDTO();
            var monAns = await _monAnSvc.GetPhanTrangMonAns(productParameters);
            prodObj.MonAns = monAns;
            prodObj.TotalCount = monAns.TotalCount;
            return Ok(prodObj);
        }

        [Route("GetMonAn")]
        [HttpGet]
        public async Task<ActionResult<MonAn>> GetMonAn([FromQuery] int id)
        {
            return await _monAnSvc.GetMonAnAsync(id);
        }

        [Route("TimMon")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetFindMonAns([FromQuery] string tenMon)
        {
            return await _monAnSvc.FindMonAnAsync(tenMon);
        }

        [Route("Mon")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetMon()
        {
            return await _monAnSvc.GetMonAnAll_MonAnAsync();
        }

        [Route("Combo")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetCombo()
        {
            return await _monAnSvc.GetMonAnAll_CombosAsync();
        }

        [Route("Nuoc")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonAn>>> GetNuoc()
        {
            return await _monAnSvc.GetMonAnAll_NuocAsync();
        }
    }
}
