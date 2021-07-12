using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.PaymentInfos.Entities;
namespace EmprendeUCR.Application.PaymentInfos.Implementations
{
    public interface IIBANCardPaymentInfoService
    {
        public  Task<IBANCardPaymentInfo?> GetIBANCardPaymentInfoByIdAsync(int id);
        public  Task<IEnumerable<IBANCardPaymentInfo>> GetIBANCardPaymentInfosAsync();
    }
}