using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Domain.Core.Repositories;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;

namespace EmprendeUCR_WebApplication.Domain.Repositories
{
    public interface  IShoppingCartRepository : IRepository<ShoppingCart>
    {
        Task SaveAsync(ShoppingCart shoppingCart);
        Task<ShoppingCart?> GetByIdAsync(string email);
        Task DeleteLine(ShopLine line);
    }
}
