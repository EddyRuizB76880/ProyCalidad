using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;

namespace EmprendeUCR.Domain.PaymentInfos.Entities
{
    public class IBANSINPEPaymentInfo
    {
        public PaymentMethod PaymentMethod;
        public string AccountNumber { get; }
        public string NameSINPE { get; private set; }
        public int PaymentInfoID { get; }
        public IBANSINPEPaymentInfo(string accountNumber, string nameSINPE)
        {
            AccountNumber = accountNumber;
            NameSINPE = nameSINPE;
        }
        // for EFCore
        protected IBANSINPEPaymentInfo()
        {
            AccountNumber = "0";
            NameSINPE = null;
        }
        public void AssignPaymentMethod(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
    }
}

