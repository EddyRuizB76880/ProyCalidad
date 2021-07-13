using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentInfos.Entities;
namespace EmprendeUCR.Application.PaymentInfos
{
    public interface ISinpeIbanPaymentInfoService
    {
        public Task<SinpeIbanPaymentInfo?> GetSinpeIbanPaymentInfoByIdAsync(string accountNumber);
        public Task<IEnumerable<SinpeIbanPaymentInfo>> GetSinpeIbanPaymentInfosAsync();
        public Task AddPaymentInfoAsync(SinpeIbanPaymentInfo sinpeIbanPaymentMethod);
    }
}