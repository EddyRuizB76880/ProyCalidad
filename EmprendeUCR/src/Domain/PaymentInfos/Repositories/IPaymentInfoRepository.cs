﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.PaymentInfos.Entities;

namespace EmprendeUCR.Domain.PaymentInfos.Repositories
{
    public interface IPaymentInfoRepository
    {
        Task SaveAsync(PaymentInfo paymentInfo);
        Task<IEnumerable<PaymentInfo>> GetAllAsync();
        Task<PaymentInfo?> GetByIDAsync(int ID);
    }
}
