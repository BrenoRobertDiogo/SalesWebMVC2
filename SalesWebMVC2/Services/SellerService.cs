using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC2.Data;
using SalesWebMVC2.Models;

namespace SalesWebMVC2.Services
{
    public class SellerService
    {
        private readonly SalesWebMVC2Context _context;

        public SellerService(SalesWebMVC2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // public List<Seller> FindAll => _context.Seller.ToList();


    }
}
