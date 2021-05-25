using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class ProductService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;

        public ProductService(Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Product>> GetAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {

            return await _context.Product.Select(product => new Product { Code_ID = product.Code_ID, Product_Name= product.Product_Name,Price = product.Price }).ToListAsync();

        }

        public int GetProductsQuantity()
        {
            /*var parameterQuantity = new Microsoft.Data.SqlClient.SqlParameter
            {
                ParameterName = "quantity",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };
            _context.Product.FromSqlRaw("EXECUTE GetQuantityProducts @quantity OUTPUT", parameterQuantity);
            return (int)parameterQuantity.Value;*/
            return _context.Product.Count();

        }
            
    }
}