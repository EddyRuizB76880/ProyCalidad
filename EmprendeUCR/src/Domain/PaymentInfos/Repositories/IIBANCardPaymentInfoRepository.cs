using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;

namespace EmprendeUCR.Domain.PaymentInfos.Repositories
{
    public interface IIBANCardPaymentInfoRepository
    {
        public Task SaveAsync(IBANCardPaymentInfo ibanCardPaymentInfo);
        Task<IEnumerable<IBANCardPaymentInfo>> GetAllAsync();
       // Task<IBANCardPaymentInfo?> GetByAccountAsync(string accountNumber);
        public Task<IBANCardPaymentInfo?> GetByIdAsync(int ID);
    }
}
