using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Entities;

namespace EmprendeUCR_WebApplication.Data.Services.PaymentMethods
{
    public class PaymentMethodService : PageModel
    {
        public PaymentMethodService(Contexts.SqlServerDbContext context)
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
        * @brief Adds a payment method to the database
        * @details 
        * @param PaymentMethod to be inserted
        * @return if the insertion was possible
        */
        public async Task<bool> InsertPaymentMethod(PaymentMethod paymentMethod)
        {
            await _context.PaymentMethod.AddAsync(paymentMethod);
            await _context.SaveChangesAsync();
            return true;
        }
        /**
        * @brief Get a payment method
        * @details 
        * @param
        * @return PaymentMethod
        */
        public async Task<IList<PaymentMethod>> GetAsync()
        {
            return await _context.PaymentMethod.ToListAsync();
        }
        /**
        * @brief Get a payment method using it's name as input
        * @details 
        * @param string name, is the PaymentMethod's name that will be retreived
        * @return PaymentMethod
        */
        public PaymentMethod getPaymentMethod(string name)
        {
            return _context.PaymentMethod.Find(name);
        }
        /**
        * @brief Removes a PaymentMethod from the database
        * @details
        * @param string name, is the PaymentMethod's name that will be deleted
        * @return
        */
        public async Task RemovePaymentMethod(string name)
        {
            PaymentMethod PaymentMethodToRemove = await _context.PaymentMethod.FindAsync(name);
            _context.PaymentMethod.Remove(PaymentMethodToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
