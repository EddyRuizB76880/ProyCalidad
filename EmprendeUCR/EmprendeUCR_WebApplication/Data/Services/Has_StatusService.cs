using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class Has_StatusService
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;

        public Has_StatusService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Has_Status>> GetAsync()    // Enlista estados
        {
            return await _context.HasStatus.ToListAsync();
        }
        public async Task<bool> InsertHas_StatusAsync(Has_Status status) // Agrega estados
        {
            await _context.HasStatus.AddAsync(status);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> InsertListOfHas_Status(IList<Has_Status> Has_Status_List) // Agrega estados en lista
        {
            try
            {
                foreach (var offer in Has_Status_List)
                {
                    await InsertHas_StatusAsync(offer);
                }
                await _context.SaveChangesAsync();
            }
            catch (InvalidOperationException)
            {

            }

            return true;
        }
        public async Task<List<Has_Status>> GetAllHas_StatusAsync()
        {
            return await _context.HasStatus.ToListAsync();        // Listado 2
        }
    }
}
