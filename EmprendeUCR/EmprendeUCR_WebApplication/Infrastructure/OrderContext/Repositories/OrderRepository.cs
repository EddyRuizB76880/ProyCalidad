using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.Core.Repositories;
using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using EmprendeUCR_WebApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* This file is used to implement the methods used by queries to take, enter or
 * change data in the EmprendeUCR database, in the context of the Orders.
 */
namespace EmprendeUCR_WebApplication.Infrastructure.OrderContext.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        /* Summary: Take the data base, in the context of the orders, and 
         *          assigns it to the _dbContext varible to use it in the 
         *          future.
         * Parameters: Receives the data base, in the context of the orders.
         * Return: Nothing.
         * Exceptions: There aren't known exceptions.
        */
        public OrderRepository(OrderDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        /* Summary: Retrieves all the orders, of a specific entrepreneur, that
         *          are in the state of "Pendiente".
         * Parameters: Receives the entrepreneur's email.
         * Return: A list of orders.
         * Exceptions: There aren't known exceptions.
        */
        public async Task<List<Order>> GetByIdAsync(string email)
        {

            List<Order> orders = await _dbContext.Orders
               .Where(order => order.EntrepreneurEmail == email && order.State == "Pendiente")
               .Include(order => order.Organized)
                    .ThenInclude(Organized => Organized.productService)
                .Include(order => order.Organized)
                    .ThenInclude(Organized => Organized.status)
               .ToListAsync();

            return orders;
        }

        /* Summary: Retrieves all the orders, of a specific client, that are in
         *          the state of "Rechazado" or "Aceptado".
         * Parameters: Receives the client's email.
         * Return: A list of orders.
         * Exceptions: There aren't known exceptions.
        */
        public async Task<List<Order>> GetClientOrdersAsync(string email)
        {
            List<Order> orders = await _dbContext.Orders
               .Where(order => order.ClientEmail == email && (order.State == "Rechazado" || order.State == "Aceptado"))
               .Include(order => order.Organized)
                    .ThenInclude(Organized => Organized.productService)
                .Include(order => order.Organized)
                    .ThenInclude(Organized => Organized.status)
               .ToListAsync();

            return orders;
        }

        /* Summary: Retrieves all the products of a specific order.
         * Parameters: Receives the order.
         * Return: A list of tuples with the products and their quantity.
         * Exceptions: There aren't known exceptions.
        */
        public async Task<List<Tuple<int, Product>>> GetProductsAsync(Order order)
        {
            List<Tuple<int, Product>> products = await _dbContext.Products
                .Include(product => product.Organized)
                .Where(product => product.Organized.Any(o => o.DateAndHourCreation == order.DateAndHourCreation && o.Email == order.ClientEmail))
                .Select(product => new Tuple<int,Product>(product.Organized.FirstOrDefault().Quantity, product))
                .ToListAsync();

            return products;
        }

        /* Summary: Update a specific order.
         * Parameters: Receives the order.
         * Return: Nothing.
         * Exceptions: There aren't known exceptions.
        */
        public async Task orderUpdate(Order OrderToUpdate)
        {
             _dbContext.Update(OrderToUpdate);

            await _dbContext.SaveEntitiesAsync();
        }


        /* Summary: Retrieves all the orders, of a specific entrepreneur, that
         * are in the state of "Finalizado".
         * Parameters: Receives the entrepreneur's email.
         * Return: A list of orders.
         * Exceptions: There aren't known exceptions.
        */
        public async Task<List<Order>> GetEntreprenurFinalizedOrders(string email)
        {
            List<Order> orders = await _dbContext.Orders
           .Where(order => order.EntrepreneurEmail == email && order.State == "Terminado")
           .Include(order => order.Organized)
                .ThenInclude(Organized => Organized.productService)
            .Include(order => order.Organized)
                .ThenInclude(Organized => Organized.status)
           .ToListAsync();

            return orders;
        }
    }
}
