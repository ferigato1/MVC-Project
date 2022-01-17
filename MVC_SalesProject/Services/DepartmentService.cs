using MVC_SalesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_SalesProject.Services
{
    public class DepartmentService
    {
        private readonly MVC_SalesProjectContext _context;

        public DepartmentService(MVC_SalesProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
