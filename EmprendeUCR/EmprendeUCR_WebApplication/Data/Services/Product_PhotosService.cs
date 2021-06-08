using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class Product_PhotosService
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;
        public Product_PhotosService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public bool Uploading (Product_Photos p_p)
        {
            _context.Product_Photos.Add(p_p);
            _context.SaveChanges();
            return true;
        }

        public List<Product_Photos> loadAllPhotos()
        {
            return _context.Product_Photos.ToList();
        }
        
    }
}
