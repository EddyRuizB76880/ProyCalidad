﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class ProductService : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Context.AppDbContext _context;

        public ProductService(EmprendeUCR_WebApplication.Data.Context.AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Product>> GetAsync()    // Enlista productos
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<bool> InsertProductAsync(Product product) // Agrega productos
        {
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Product.ToListAsync();
        }

    }
}

