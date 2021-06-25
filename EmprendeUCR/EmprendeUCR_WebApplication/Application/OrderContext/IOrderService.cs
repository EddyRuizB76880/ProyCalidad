using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;

namespace EmprendeUCR_WebApplication.Application.OrderContext
{ 
    // Interface implementation for the OrderService
    interface IOrderService
    {
        // Interface declaration methods for the OrderService 
        Task <List<Order>> GetEntrepreneurOrders(string email);
        Task <List<Order>> GetClientOrders(string email);
        Task <List<Tuple<int, Product>>> GetProducts(Order order);
        Task <string> getEntrepreneurName(string email);
        Task<List<Order>> sendAnswer(DateTime dateAndHourCreation, string email, bool answer,List<Order> orderToUpdate);
    }
}
