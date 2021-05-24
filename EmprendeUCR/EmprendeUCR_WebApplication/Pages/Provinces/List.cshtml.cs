using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Contexts;
using EmprendeUCR_WebApplication.Data.Entities;

namespace EmprendeUCR_WebApplication.Pages.Provinces
{
    public class ListModelProvinces : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;

        public ListModelProvinces(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public IList<Province> Province { get; set; }

        public async Task OnGetAsync()
        {
            Province = await _context.Province.ToListAsync();
        }

        public Province province { get; set; }
        public void addProvince(Province province)
        {
            _context.Province.Add(province);
            _context.SaveChanges();
        }
    }
}