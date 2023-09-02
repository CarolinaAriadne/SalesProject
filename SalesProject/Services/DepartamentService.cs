
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProject.Models;


namespace SalesProject.Services
{
    public class DepartamentService
    {

        private readonly SalesProjectContext _context;

        public DepartamentService(SalesProjectContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(d => d.Name).ToList();
        }
    }
}
