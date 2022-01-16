using MVC_SalesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SalesProject.Services
{
    public class DepartmentService
    {
        private readonly MVC_SalesProjectContext _context;

        public DepartmentService(MVC_SalesProjectContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
