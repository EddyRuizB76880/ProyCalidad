using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.Core.Repositories;
using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* This file is used as a interface of the file OrderRepository.
 */
namespace EmprendeUCR_WebApplication.Domain.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<List<Order>?> GetByIdAsync(string email);

        Task<List<Order>?> GetEntreprenurFinalizedOrders(string email);
        Task<List<Order>?> GetClientOrdersAsync(string email);
        Task<List<Tuple<int, Product>>> GetProductsAsync(Order order);
        Task orderUpdate(Order orderToUpdate);
    }
}
