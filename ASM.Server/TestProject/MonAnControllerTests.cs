using ASM.API.Controllers;
using ASM.Share.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class MonAnControllerTests
    {
        private readonly Mock<IMonAnSvc> _mockMonAn;
        private readonly MonAnController _controller;
        public MonAnControllerTests()
        {
            _mockMonAn = new Mock<IMonAnSvc>();
            _controller = new MonAnController(_mockMonAn.Object);
        }

        [Fact]
        public async Task GetMonAnAll_ActionExcutes_ReturnsViewForGetMonAnAll()
        {
            var result = await _controller.GetMonAnAll();
            Assert.IsType<ActionResult<IEnumerable<MonAn>>>(result);
        }

        [Fact]
        public async Task GetMonAn_ActionExcutes_ReturnsViewGetMonAn()
        {
            var result = await _controller.GetMonAn(1);
            Assert.IsType<ActionResult<MonAn>>(result);
        }
    }
}
