using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentMethods.Entities;
namespace EmprendeUCR.Application.PaymentMethods
{
    public interface IPaymentMethodService
    {
        Task<IEnumerable<PaymentMethod>> GetPaymentMethodsAsync();
        Task<PaymentMethod?> GetPaymentMethodByIdAsync(string name);
        Task ChangeStatusToPaymentMethodAsync(PaymentMethod paymentMethod);
    }
}