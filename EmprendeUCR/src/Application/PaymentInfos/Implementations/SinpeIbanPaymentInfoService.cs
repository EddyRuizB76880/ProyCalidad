using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Domain.PaymentInfos.Repositories;
namespace EmprendeUCR.Application.PaymentInfos.Implementations
{
    internal class SinpeIbanPaymentInfoService : ISinpeIbanPaymentInfoService
    {
        private readonly ISinpeIbanPaymentInfoRepository _sinpeIbanPaymentInfoRepository;
        public SinpeIbanPaymentInfoService(ISinpeIbanPaymentInfoRepository sinpeIbanPaymentInfoRepository)
        {
            _sinpeIbanPaymentInfoRepository = sinpeIbanPaymentInfoRepository;
        }
        public async Task AddPaymentInfoAsync(SinpeIbanPaymentInfo sinpeIbanPaymentInfo)
        {
            await _sinpeIbanPaymentInfoRepository.AddPaymentInfo(sinpeIbanPaymentInfo);
        }
        public async Task<SinpeIbanPaymentInfo?> GetSinpeIbanPaymentInfoByIdAsync(string accountNumber)
        {
            return await _sinpeIbanPaymentInfoRepository.GetByIdAsync(accountNumber);
        }
        public async Task<IEnumerable<SinpeIbanPaymentInfo>> GetSinpeIbanPaymentInfosAsync()
        {
            return await _sinpeIbanPaymentInfoRepository.GetAllAsync();
        }
    }
}