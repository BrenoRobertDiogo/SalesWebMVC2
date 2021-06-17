using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC2.Models;

namespace SalesWebMVC2.Data
{
    public class SeedingService
    {
        private SalesWebMVC2Context _context;

        public SeedingService(SalesWebMVC2Context context) {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() || 
                _context.SalesRecord.Any())
            {

            }
        }
    }
}
