using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Domain.Repositories;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;
using EmprendeUCR_WebApplication.Infrastructure.ShoppingCartContext;
using EmprendeUCR_WebApplication.Domain.Core.Repositories;

namespace EmprendeUCR_WebApplication.Infrastructure.Core
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ShoppingCartDbContext2 _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public ShoppingCartRepository(ShoppingCartDbContext2 unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        public Task DeleteLine(ShopLine shopLine)
        {
            _dbContext.ShopLines.Remove(shopLine);
            return Task.CompletedTask;
        }

        public async Task<ShoppingCart?> GetByIdAsync(string email)
        {
            ShoppingCart shop = await _dbContext.ShoppingCarts
               .Include(shop => shop.ShopLines)
                    .ThenInclude(has => has.product)
               .FirstOrDefaultAsync(t => t.Email == email);
            return shop;
        }

        public async Task SaveAsync(ShoppingCart shoppingCart)
        {
            _dbContext.Update(shoppingCart);

            await _dbContext.SaveEntitiesAsync();
        }

    }
       
    }
