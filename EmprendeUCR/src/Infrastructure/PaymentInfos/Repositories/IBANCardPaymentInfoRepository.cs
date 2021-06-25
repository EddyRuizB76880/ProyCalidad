using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
using EmprendeUCR.Infrastructure.Core;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR.Infrastructure.PaymentInfo;
namespace EmprendeUCR.Infrastructure.PaymentInfos.Repositories
{
    internal class IBANCardPaymentInfoRepository : IIBANCardPaymentInfoRepository
    {
        private readonly IBANCardPaymentInfosDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public IBANCardPaymentInfoRepository(IBANCardPaymentInfosDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
      public async Task<IEnumerable<IBANCardPaymentInfo>> GetAllAsync()
        {
           return await _dbContext.IBANCardPaymentInfo
           .Select(p => new IBANCardPaymentInfo(p.AccountNumber,p.NameCard))
           .ToListAsync();
        }
        public async Task<IBANCardPaymentInfo?> GetByIdAsync(int ID)
        {
            return await _dbContext.IBANCardPaymentInfo
            .FirstOrDefaultAsync(t => t.PaymentInfoID == ID);
        }
        public async Task SaveAsync(IBANCardPaymentInfo IBANCardPaymentInfo)
        {
            _dbContext.Update(IBANCardPaymentInfo);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}