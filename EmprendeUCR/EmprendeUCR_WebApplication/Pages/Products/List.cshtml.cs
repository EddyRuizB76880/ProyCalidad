using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Context;
using EmprendeUCR_WebApplication.Data.Entities;

namespace EmprendeUCR_WebApplication.Pages.Products
{
    public class ListModel : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Context.AppDbContext _context;

        public ListModel(EmprendeUCR_WebApplication.Data.Context.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {

            Product = (IList<Product>)await _context.Product.ToListAsync();
        }
    }
}
