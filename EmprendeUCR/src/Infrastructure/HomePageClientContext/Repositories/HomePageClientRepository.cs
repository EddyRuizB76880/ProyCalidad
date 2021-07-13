﻿using EmprendeUCR.Domain.Core.CoreEntities;
using EmprendeUCR.Domain.Core.Repositories;
using EmprendeUCR.Domain.HomePageClientContext.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprendeUCR.Infrastructure.HomePageClientContext.Repositories
{
    public class HomePageClientRepository : IHomePageClientRepository
    {
        private readonly HomePageClientDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;

        public HomePageClientRepository(HomePageClientDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Product> getNewProducts()
        {
            return _dbContext.Product.FromSqlRaw("exec getNewProducts").ToArray();
        }
        public IList<Product> getOfferProducts()
        {
            return _dbContext.Product.FromSqlRaw("exec getOfferProducts").ToArray();
        }
        public IList<Product> getRecommendedProducts(string userEmail)
        {
            return _dbContext.Product.FromSqlRaw("exec getRecommendedProducts \"" + userEmail + "\"").ToArray();
        }
        public IList<ProductPhotos> loadAllPhotos() 
        {
            return _dbContext.ProductPhotos.ToList();
        }

        public async Task<IList<Category>> getCategoriesAsync() 
        {
            return await _dbContext.Category.ToListAsync();
        }

        public async Task changeCategoryParent(int Id, int? ParentId) 
        {
            Category source = _dbContext.Category.Find(Id);
            source.ParentId = ParentId;
            _dbContext.Category.Update(source);
            await _dbContext.SaveChangesAsync();
        }

        public bool isChildNode(int Id)
        {
            bool isChild = false;
            if (_dbContext.Category.Where(c => c.ParentId.Equals(Id)).Count() == 0)
            {
                isChild = true;
            }
            return isChild;
        }
        public async Task<bool> searchProduct(string email, int idProduct) 
        {
            ShoppingCartHas existing = await _dbContext.ShoppingCartHas.FirstOrDefaultAsync(c => c.Email.Equals(email) && c.Code_ID == idProduct);
            if (existing != null)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> addProduct(ShoppingCartHas product) 
        {
            await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Offer>> GetOffers()
        {

            return await _dbContext.Offer.ToListAsync();        // Listado 2
        }

        public async Task<List<ProductService>> GetAllProducts()
        {
            return await _dbContext.ProductService.ToListAsync();        // Listado 2
        }

        public IList<Product> GetPurchasedProducts(string email)
        {
            return _dbContext.Product.FromSqlRaw("exec products_based_last_purchases \"" + email + "\"").ToArray();
        }

        public IList<Is_Offer> GetAllIs_Offer()
        {
            return _dbContext.Is_Offer.FromSqlRaw("exec get_unique_offers").ToArray();
        }

        public IList<Service_Photos> GetAllServicePhotos()
        {
            return _dbContext.Service_Photos.ToList();
        }
    }
}