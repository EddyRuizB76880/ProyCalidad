using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmprendeUCR_WebApplication.Data.Services.PaymentMethods
{
    public class SinpePaymentMethodService : PageModel
    {
        private readonly Contexts.SqlServerDbContext _context;
        public SinpePaymentMethodService(Contexts.SqlServerDbContext context)
        {
            _context = context;
        }
        public async Task<IList<SinpePaymentMethod>> GetAsync()
        {
            return await _context.SinpePaymentMethod.ToListAsync();
        }
        public int getSinpePhoneNumber(string Email)
        {
            return _context.SinpePaymentMethod.Find(Email).Phone_Number;
        }

        public async void AddSinpePaymentMethod(int Phone_Number, string Email)
        {
            SinpePaymentMethod Sinpe = new SinpePaymentMethod();
            Sinpe.Phone_Number = Phone_Number;
            Sinpe.Entrepreneur_Email = Email;
            await _context.SinpePaymentMethod.AddAsync(Sinpe);
            await _context.SaveChangesAsync();
        }

        public void DeleteSinpePaymentMethod(string Email)
        {

        }

    }
}
