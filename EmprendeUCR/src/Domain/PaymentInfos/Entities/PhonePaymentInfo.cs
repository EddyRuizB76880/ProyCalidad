using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;

namespace EmprendeUCR.Domain.PaymentInfos.Entities
{
    public class PhonePaymentInfo
    {
        public PaymentMethod PaymentMethod;
        public int PhoneNumber { get; }
        public string NameSINPEMovil { get; private set; }
        public int PaymentInfoID { get; }
        public PhonePaymentInfo(int phoneNumber, string nameSINPEMovil)
        {
            PhoneNumber = phoneNumber;
            NameSINPEMovil = nameSINPEMovil;
        }
        // for EFCore
        protected PhonePaymentInfo()
        {
            PhoneNumber = 0;
            NameSINPEMovil = null;
        }
        public void AssignPaymentMethod(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
    }
}

