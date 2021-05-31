﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class EntrepreneurService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;

        public EntrepreneurService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Entrepreneur>> GetAsync()    // Enlista Emprendededores
        {
            return await _context.Entrepreneur.ToListAsync();
        }

        public async Task<bool> InsertEntrepreneurAsync(Entrepreneur entrepreneur) // Agrega emprendedores
        {
            await _context.Entrepreneur.AddAsync(entrepreneur);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> UpdateEntrepreneurAsync(Entrepreneur entrepreneur) // Modifica emprendedores
        {
            _context.Entrepreneur.Update(entrepreneur);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> DeleteEntrepreneurAsync(Entrepreneur entrepreneur)// Elimina Emprendedores
        {
            _context.Entrepreneur.Remove(entrepreneur);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<Entrepreneur> GetEntrepreneurAsync(string email)
        {
            Entrepreneur entrepreneur = await _context.Entrepreneur.FirstOrDefaultAsync(c => c.User_Email.Equals(email));
            return entrepreneur;
        }


        public async Task<List<Entrepreneur>> GetAllEntrepreneursAsync() // Listado 2
        {
            return await _context.Entrepreneur.ToListAsync();        
        }
    }
}
