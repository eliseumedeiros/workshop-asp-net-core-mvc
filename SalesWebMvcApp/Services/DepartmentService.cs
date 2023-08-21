using SalesWebMvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcApp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcAppContext _context;

        public DepartmentService(SalesWebMvcAppContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
