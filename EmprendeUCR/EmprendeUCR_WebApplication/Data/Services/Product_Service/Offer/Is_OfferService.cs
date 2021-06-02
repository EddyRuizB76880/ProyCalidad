using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Services
{
    public class Is_OfferService : PageModel
    {
        private readonly EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext _context;

        public Is_OfferService(EmprendeUCR_WebApplication.Data.Contexts.SqlServerDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Is_Offer>> GetAsync()    // Enlista Ofertas
        {
            return await _context.Is_Offer.ToListAsync();
        }

        public async Task<bool> InsertIs_OfferAsync(Is_Offer offer) // Agrega Ofertas
        {
            await _context.Is_Offer.AddAsync(offer);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> UpdateIs_OfferAsync(Is_Offer offer) // Update Ofertas
        {

            _context.Is_Offer.Update(offer);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<bool> DeleteIs_OfferAsync(Is_Offer offer) // Eliminar Ofertas
        {
            _context.Is_Offer.Remove(offer);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<Is_Offer> GetIs_OfferAsync(int Is_Offer_Id)
        {
            Is_Offer offer = await _context.Is_Offer.FirstOrDefaultAsync(c => c.Offer_ID.Equals(Is_Offer_Id));

            return null;
        }


        public async Task<List<Is_Offer>> GetAllIs_OffersAsync()
        {

            return await _context.Is_Offer.ToListAsync();        // Listado 2
        }
        /**
        public async Task<IList<Offer>> GetOfferFromEntrepreneurAsync(string email)
        {

            return await _context.Offer.Where(c => String.Equals(c.Offer_Id, email)).ToListAsync();

        }
        */
    }

}

