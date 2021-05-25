using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace EmprendeUCR_WebApplication.Data.Services
{
    public class UserService
    {
        private readonly EmprendeUCR_WebApplication.Data.Context.AppDbContext _context;

        public async Task<IList<User>> GetAsync()    // Enlista Emprendededores
        {
            return await _context.User.ToListAsync();
        }
    }
}
