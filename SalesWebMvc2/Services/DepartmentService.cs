using SalesWebMvc2.Data;
using SalesWebMvc2.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc2.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc2Context _context;

        public DepartmentService(SalesWebMvc2Context context)
        {
            _context = context;
        }


        public List<Department>FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
