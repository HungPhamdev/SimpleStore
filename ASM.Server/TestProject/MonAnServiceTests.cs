using ASM.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class MonAnServiceTests
    {
        private DataContext _context;
        private MonAnSvc _unitTestMonAn = null;
        public MonAnServiceTests(DataContext context)
        {
            _context = context;
            if (_unitTestMonAn == null)
            {
                _unitTestMonAn = new MonAnSvc(_context);
            }
        }

        [Fact]
        public MonAn GetMonAn(int id)
        {

        }
    }
}
