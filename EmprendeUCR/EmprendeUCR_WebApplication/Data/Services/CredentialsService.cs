using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class CredentialsService : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;

        public CredentialsService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Credentials>> GetAsync()
        {
            return await _context.Credentials.ToListAsync();
        }

        public void AddCredentials(Credentials credentials)
        {
            _context.Credentials.Add(credentials);
            _context.SaveChanges();
        }
    }
}
