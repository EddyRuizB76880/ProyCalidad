using EmprendeUCR_WebApplication.Domain.OrderContext.Entities;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;
using System;
using System.Collections.Generic;

/* This file is used to map the "Product_Service" table and to used as a 
 * ProductService entity.
 */
namespace EmprendeUCR_WebApplication.Domain.Core.CoreEntities
{
    public class ProductService
    {
        public int CodeId { get; set; }
        public string EntrepreneurEmail { get; set; }
        public byte Availability { get; set; }
        public int CategoryId { get; set; }

        // Foreign entities
        private readonly List<Organized> _organizedList;
        public IReadOnlyCollection<Organized> Organized;
        private readonly List<ShopLine> shoppingCartHas;
        public IReadOnlyCollection<ShopLine> ShoppingCartHas => shoppingCartHas.AsReadOnly();
    }
}
