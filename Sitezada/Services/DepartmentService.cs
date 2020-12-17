using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitezada.Models;
using Sitezada.Data;
using Microsoft.EntityFrameworkCore;

namespace Sitezada.Services
{
    public class DepartmentService
    {
        private readonly SitezadaContext _context;

        public DepartmentService(SitezadaContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
