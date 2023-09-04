
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProject.Models;
using Microsoft.EntityFrameworkCore;


namespace SalesProject.Services
{
    public class DepartamentService
    {

        private readonly SalesProjectContext _context;

        public DepartamentService(SalesProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
