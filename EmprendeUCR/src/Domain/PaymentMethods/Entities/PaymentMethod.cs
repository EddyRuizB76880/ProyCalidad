using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.Exceptions;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using System.Collections.Generic;
namespace EmprendeUCR.Domain.PaymentMethods.Entities
{
    public class PaymentMethod
    {
        public IReadOnlyCollection<IBANCardPaymentInfo> IBANCardPaymentInfos;
        private readonly List<IBANCardPaymentInfo> _IBANCardPaymentInfos;

        public IReadOnlyCollection<IBANSINPEPaymentInfo> IBANSINPEPaymentInfos;
        private readonly List<IBANSINPEPaymentInfo> _IBANSINPEPaymentInfos;

        public IReadOnlyCollection<PhonePaymentInfo> PhonePaymentInfos;
        private readonly List<PhonePaymentInfo> _phonePaymentInfos;


        public string Name { get; }
        public bool Status { get; private set; }
        public int Type { get; }
        public PaymentMethod(string name, bool status, int type)
        {
            Name = name;
            Status = status;
            Type = type;
            _IBANCardPaymentInfos = new List<IBANCardPaymentInfo>();
            _IBANSINPEPaymentInfos = new List<IBANSINPEPaymentInfo>();
            _phonePaymentInfos = new List<PhonePaymentInfo>();
        }
        // for EFCore
        protected PaymentMethod()
        {
            Name = null;
            Status = false;
            Type = -1;
        }

        public void ChangeStatus()
        {
            Status = !Status;
        }
        public void AddIBANCardPaymentInfo(IBANCardPaymentInfo paymentInfo)
        {
            if (_IBANCardPaymentInfos.Exists(p => p.AccountNumber == paymentInfo.AccountNumber))
                throw new DomainException("La cuenta IBAN ya se encuentra agregada");
            _IBANCardPaymentInfos.Add(paymentInfo);
            paymentInfo.AssignPaymentMethod(this);
        }
        public void AddIBANSINPEPaymentInfo(IBANSINPEPaymentInfo paymentInfo)
        {
            if (_IBANCardPaymentInfos.Exists(p => p.AccountNumber == paymentInfo.AccountNumber))
                throw new DomainException("La cuenta IBAN ya se encuentra agregada");
            _IBANSINPEPaymentInfos.Add(paymentInfo);
            paymentInfo.AssignPaymentMethod(this);
        }
        public void AddPhonePaymentInfo(PhonePaymentInfo paymentInfo)
        {
            if (_phonePaymentInfos.Exists(p => p.PhoneNumber == paymentInfo.PhoneNumber))
                throw new DomainException("Ese número de teléfono ya se encuentra agregado");
            _phonePaymentInfos.Add(paymentInfo);
            paymentInfo.AssignPaymentMethod(this);
        }
    }
}