using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;
using System;
using System.Collections.Generic;


namespace EmprendeUCR_WebApplication.Domain.Core.CoreEntities
{
    public class ProductService
    {
        private readonly List<ShopLine> shoppingCartHas;
        public int CodeId { get; set; }
        public string EntrepreneurEmail { get; set; }
        public byte Availability { get; set; }
        public int CategoryId { get; set; }
        public IReadOnlyCollection<ShopLine> ShoppingCartHas => shoppingCartHas.AsReadOnly();
    }
}
