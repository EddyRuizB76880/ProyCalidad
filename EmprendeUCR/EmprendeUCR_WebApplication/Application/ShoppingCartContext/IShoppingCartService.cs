using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;

namespace EmprendeUCR_WebApplication.Application.ShoppingCartContext
{
    interface IShoppingCartService
    {
        
        Task<ShoppingCart?> GetByIdAsync(string email);
        Task DeleteLineFromShoppingCart(ShoppingCart shoppingCart, ShopLine shopLine);
    }
}
