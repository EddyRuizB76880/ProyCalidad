using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using EmprendeUCR.Domain.PaymentMethods.Repositories;
using EmprendeUCR.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
namespace EmprendeUCR.Infrastructure.PaymentMethods.Repositories
{
    internal class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly PaymentMethodsDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public PaymentMethodRepository(PaymentMethodsDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
        public async Task<IEnumerable<PaymentMethod>> GetAllAsync()
        {
            return await _dbContext.PaymentMethod
            .Select(p => new PaymentMethod(p.Name, p.Status, p.Type))
            .ToListAsync();
        }
        public async Task<PaymentMethod?> GetByIdAsync(string name)
        {
            return await _dbContext.PaymentMethod
            .FirstOrDefaultAsync(t => t.Name == name);
        }
        /// <summary>
        /// Saves aggregate and commits changes
        /// </summary>
        public async Task SaveAsync(PaymentMethod paymentMethod)
        {
            _dbContext.Update(paymentMethod);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}