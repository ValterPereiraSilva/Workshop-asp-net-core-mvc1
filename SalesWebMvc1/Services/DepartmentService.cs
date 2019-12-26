using SalesWebMvc1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc1.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc1Context _context;

        public DepartmentService(SalesWebMvc1Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
