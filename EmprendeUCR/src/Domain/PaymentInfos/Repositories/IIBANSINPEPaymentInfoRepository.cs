using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;

namespace EmprendeUCR.Domain.IBANSINPEPaymentInfos.Repositories
{
    public interface IIBANSINPEPaymentInfoRepository
    {
        Task SaveAsync(IBANSINPEPaymentInfo ibanSINPEPaymentInfo);
        Task<IEnumerable<IBANSINPEPaymentInfo>> GetAllAsync();
        Task<IBANSINPEPaymentInfo?> GetByAccountAsync(string accountNumber);
        Task<IBANSINPEPaymentInfo?> GetByIDAsync(int ID);
    }
}
