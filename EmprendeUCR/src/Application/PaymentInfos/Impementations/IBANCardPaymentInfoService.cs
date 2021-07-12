using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
namespace EmprendeUCR.Application.PaymentInfos.Implementations


{
    internal class IBANCardPaymentInfoService : IIBANCardPaymentInfoService
    {
        private readonly IIBANCardPaymentInfoRepository _IBANCardPaymentInfoRepository;

        public IBANCardPaymentInfoService(IIBANCardPaymentInfoRepository IBANPaymentInfoRepository)
        {
            _IBANCardPaymentInfoRepository = IBANPaymentInfoRepository;
        }
        public async Task<IBANCardPaymentInfo?> GetIBANCardPaymentInfoByIdAsync(int id)
        {
            return await _IBANCardPaymentInfoRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<IBANCardPaymentInfo>> GetIBANCardPaymentInfosAsync()
        {
            return await _IBANCardPaymentInfoRepository.GetAllAsync();
        }
    }
}
