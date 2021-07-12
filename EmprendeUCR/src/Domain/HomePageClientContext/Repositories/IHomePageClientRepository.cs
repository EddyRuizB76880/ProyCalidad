using EmprendeUCR.Domain.Core.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprendeUCR.Domain.HomePageClientContext.Repositories
{
    public interface IHomePageClientRepository
    {
        IList<Product> getNewProducts();
        IList<Product> getOfferProducts();
        IList<Product> getRecommendedProducts(string userEmail);
        IList<ProductPhotos> loadAllPhotos();
        Task<IList<Category>> getCategoriesAsync();
        Task changeCategoryParent(int Id, int? ParentId);
        bool isChildNode(int Id);
        Task<bool> searchProduct(string email, int idProduct);
        Task<bool> addProduct(ShoppingCartHas product);
        Task<List<Offer>> GetOffers();
        Task<List<ProductService>> GetAllProducts();
        IList<Product> GetPurchasedProducts(string email);
    }
}