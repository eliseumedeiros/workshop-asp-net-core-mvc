using SalesWebMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcApp.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcAppContext _context;

        public SellerService(SalesWebMvcAppContext context)
        {
            _context = context;
        }

        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }
    }
}
