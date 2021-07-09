using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentMethods.Entities;
namespace EmprendeUCR.Domain.PaymentMethods.Repositories
{
    public interface IPaymentMethodRepository
    {
        Task SaveAsync(PaymentMethod paymentMethod);
        Task<IEnumerable<PaymentMethod>> GetAllAsync();
        Task<PaymentMethod?> GetByIdAsync(string name);
    }
}