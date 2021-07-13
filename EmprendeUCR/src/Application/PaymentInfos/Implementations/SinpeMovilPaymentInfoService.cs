using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
namespace EmprendeUCR.Application.PaymentInfos.Implementations
{
    internal class SinpeMovilPaymentInfoService : ISinpeMovilPaymentInfoService
    {
        private readonly ISinpeMovilPaymentInfoRepository _sinpeMovilPaymentInfoRepository;

        public SinpeMovilPaymentInfoService(ISinpeMovilPaymentInfoRepository sinpeMovilPaymentInfoRepository)
        {
            _sinpeMovilPaymentInfoRepository = sinpeMovilPaymentInfoRepository;
        }

        public async Task AddPaymentInfoAsync(SinpeMovilPaymentInfo sinpeMovilPaymentInfo)
        {
            await _sinpeMovilPaymentInfoRepository.AddPaymentInfo(sinpeMovilPaymentInfo);
        }

        public async Task<SinpeMovilPaymentInfo?> GetSinpeMovilPaymentInfoByIdAsync(int phoneNumber)
        {
            return await _sinpeMovilPaymentInfoRepository.GetByIdAsync(phoneNumber);
        }
        public async Task<IEnumerable<SinpeMovilPaymentInfo>> GetSinpeMovilPaymentInfosAsync()
        {
            return await _sinpeMovilPaymentInfoRepository.GetAllAsync();
        }

    }
}