using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.Repositories;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;

namespace EmprendeUCR_WebApplication.Application.ShoppingCartContext.Implementations
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartService(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }
        public async Task DeleteLineFromShoppingCart(ShoppingCart shoppingCart,ShopLine shopLine)
        {
            shoppingCart.DeleteProductFromShoppingCart(shopLine);
            await _shoppingCartRepository.DeleteLine(shopLine);
            await _shoppingCartRepository.SaveAsync(shoppingCart);
        }

        public async Task<ShoppingCart?> GetByIdAsync(string email)
        {
            return await _shoppingCartRepository.GetByIdAsync(email);
        }
    }
}
