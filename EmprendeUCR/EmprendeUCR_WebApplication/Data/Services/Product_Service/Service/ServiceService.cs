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
    public class ServiceService : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;

        public ServiceService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Service>> GetAsync()    // Enlista productos
        {
            return await _context.Service.ToListAsync();
        }

        public async Task<bool> InsertServiceAsync(Service service) // Agrega productos
        {
            await _context.Service.AddAsync(service);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> UpdateServiceAsync(Service service) // Update productos
        {
            _context.Service.Update(service);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> DeleteServiceAsync(Service service) // Eliminar productos
        {
            _context.Service.Remove(service);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<Service> GetServiceAsync(int Id)
        {
            Service service = await _context.Service.FirstOrDefaultAsync(c => c.Code_ID.Equals(Id));
            return service;
        }


        public async Task<List<Service>> GetAllServiceAsync()
        {
            return await _context.Service.ToListAsync();        // Listado 2
        }

        public async Task<IList<Service>> GetServiceEntrepreneurAsync(string email)
        {
            return await _context.Service.Where(c => String.Equals(c.Entrepreneur_Email, email)).ToListAsync();

        }

        public async Task<IEnumerable<Service>> GetServices()
        {

            return await _context.Service.Select(service => new Service { Code_ID = service.Code_ID, Service_Name = service.Service_Name, Price_per_hour = service.Price_per_hour }).ToListAsync();

        }

        public int GetServiceQuantity()
        {
            return _context.Service.Count();
        }
    }
}
