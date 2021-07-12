using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Entities;

namespace EmprendeUCR_WebApplication.Data.Services.PaymentMethods
{
    public class CardService : PageModel
    {
        public CardService(Contexts.SqlServerDbContext context)
        {
            _context = context;
        }
        /*
         * 
         * Private Variables
         * 
         */
        private readonly Contexts.SqlServerDbContext _context;

        /**
        * @brief Adds a card Payment Method to the database
        * @details 
        * @param card Payment Method to be inserted
        * @return if the insertion was possible
        */
        public async Task<bool> InsertCard(Card card)
        {
            await _context.Card.AddAsync(card);
            await _context.SaveChangesAsync();
            return true;
        }
        /**
        * @brief Get a card payment method
        * @details 
        * @param
        * @return card
        */
        public async Task<IList<Card>> GetAsync()
        {
            return await _context.Card.ToListAsync();
        }
        /**
        * @brief Get a card payment method using it's brand as input
        * @details 
        * @param string brand, is the card's brand that will be retreived
        * @return card
        */
        public Card GetCard(string brand)
        {
            return _context.Card.Find(brand);
        }
        /**
        * @brief Removes a card Payment Method from the database
        * @details
        * @param string brand, is the card's brand that will be deleted
        * @return
        */
        public async Task RemoveCard(string brand)
        {
            Card CardToRemove = await _context.Card.FindAsync(brand);
            _context.Card.Remove(CardToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
