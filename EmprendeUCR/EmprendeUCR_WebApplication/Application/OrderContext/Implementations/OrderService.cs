using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.Repositories;

namespace EmprendeUCR_WebApplication.Application.OrderContext.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        /*
          Summary: Method to get the orders of an entrepreneur related to an email.
          Parameters: Method gets string email related to an user.
          Return: An order asociated to an email
          Exceptions: There aren't known exceptions
        */
        public async Task<string> GetEntrepreneurName(string email)
        {
            throw new NotImplementedException();
        }

        /*
          Summary: Method to get the orders of an entrepreneur related to an email.
          Parameters: Method gets string email related to an user.
          Return: An order asociated to an email
          Exceptions: There aren't known exceptions
        */
        public async Task<List<Order>> GetEntrepreneurOrders(string email)
        {
            return await _orderRepository.GetByIdAsync(email);
        }

        /*
          Summary: Method to get the orders of a client related to an email.
          Parameters: Method gets string email related to an user.
          Return: Returns a list of orders related to an email
          Exceptions: There aren't known exceptions
        */
        public async Task<List<Order>> GetClientOrders(string email)
        {
            return await _orderRepository.GetClientOrdersAsync(email);
        }

        /*
          Summary: Method to get the products related to an order.
          Parameters: Method receives an order object.
          Return: Returns a list of products related to related to an order.
          Exceptions: There aren't known exceptions
        */
        public async Task<List<Tuple<int, Product>>> GetProducts(Order order)
        {
            return await _orderRepository.GetProductsAsync(order);
        }

        /*
          Summary: Method to send an answer from an entrepreneur to a client.
          Parameters: Method receives a date and hour, an email, the answer to be sent and the order to update.
          Return: Returns a List of orders
          Exceptions: There aren't known exceptions
        */
        public async Task<List<Order>>sendAnswer(DateTime dateAndHourCreation, string email, bool answer, List<Order> ordersToUpdate)
        {
            Order orderToUpdate = ordersToUpdate.FirstOrDefault(order => order.DateAndHourCreation == dateAndHourCreation && order.ClientEmail == email);
            orderToUpdate.changeGlobalStatus(answer ? "Aceptado" : "Rechazado" );
            await _orderRepository.orderUpdate(orderToUpdate);
            ordersToUpdate.RemoveAll(r => r.DateAndHourCreation == dateAndHourCreation && r.ClientEmail == email);
            return  ordersToUpdate;
        }

        /*
          Summary: Method to get the entrepreneur name.
          Parameters: Method receives an email.
          Return: Nothing
          Exceptions: There aren't known exceptions
        */
        public Task<string> getEntrepreneurName(string email)
        {
            throw new NotImplementedException();
        }
    }
}
