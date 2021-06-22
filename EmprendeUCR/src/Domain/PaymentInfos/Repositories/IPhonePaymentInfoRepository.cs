using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;

namespace EmprendeUCR.Domain.PaymentMethods.Repositories
{
    public interface IPhonePaymentInfoRepository
    {
        Task SaveAsync(PhonePaymentInfo phonePaymentInfo);
        Task<IEnumerable<PhonePaymentInfo>> GetAllAsync();
        Task<PhonePaymentInfo?> GetByNumberAsync(int number);
        Task<PhonePaymentInfo?> GetByIDAsync(int ID);
    }
}
