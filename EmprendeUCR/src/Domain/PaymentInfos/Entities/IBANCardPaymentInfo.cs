using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.Exceptions;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;

namespace EmprendeUCR.Domain.PaymentInfos.Entities
{
    public class IBANCardPaymentInfo
    {
        public PaymentMethod PaymentMethod;
        public string AccountNumber { get; }
        public string NameCard { get; private set; }
        public int PaymentInfoID { get; }
        public IBANCardPaymentInfo(string accountNumber, string nameCard)
        {
            AccountNumber = accountNumber;
            NameCard = nameCard;
        }
        // for EFCore
        protected IBANCardPaymentInfo()
        {
            AccountNumber = "0";
            NameCard = null;
        }
        public void AssignPaymentMethod(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

    }
}

