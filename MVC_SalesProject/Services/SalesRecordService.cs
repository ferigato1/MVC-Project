using Microsoft.EntityFrameworkCore;
using MVC_SalesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SalesProject.Services
{
    public class SalesRecordService
    {
        private readonly MVC_SalesProjectContext _context;

        public SalesRecordService(MVC_SalesProjectContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(i => i.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(i => i.Date <= maxDate.Value);
            }
            return await result
                .Include(x=>x.Seller)
                .Include(x=>x.Seller.Department)
                .OrderByDescending(x=>x.Date)
                .ToListAsync();
        }
    }
}
