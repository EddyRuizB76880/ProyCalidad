using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using EmprendeUCR.Domain.PaymentMethods.Repositories;
namespace EmprendeUCR.Application.PaymentMethods.Implementations
{
    internal class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;
        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }
        public async Task<PaymentMethod?> GetPaymentMethodByIdAsync(string name)
        {
            return await _paymentMethodRepository.GetByIdAsync(name);
        }
        public async Task<IEnumerable<PaymentMethod>> GetPaymentMethodsAsync()
        {
            return await _paymentMethodRepository.GetAllAsync();
        }

        public async Task ChangeStatusToPaymentMethodAsync(PaymentMethod paymentMethod)
        {
            paymentMethod.ChangeStatus();
            await _paymentMethodRepository.SaveAsync(paymentMethod);
        }
    }
}