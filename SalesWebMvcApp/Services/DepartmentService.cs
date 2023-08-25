using Microsoft.EntityFrameworkCore;
using SalesWebMvcApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcApp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcAppContext _context;

        public DepartmentService(SalesWebMvcAppContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
