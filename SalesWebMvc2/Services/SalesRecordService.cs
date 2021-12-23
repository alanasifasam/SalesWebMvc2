using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMvc2.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvc2Context _context;

        public SalesRecordService(SalesWebMvc2Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindyByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            };
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x=>x.Seller)
                .Include(x=>x.Seller.Department)
                .OrderByDescending(x=>x.Date)
                .ToListAsync();

        }

        public async Task<List<IGrouping<Department,SalesRecord>>> FindyByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            };
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x=>x.Seller.Department)
                .ToListAsync();

        }


    }
}
