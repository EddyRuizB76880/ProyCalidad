using EmprendeUCR_WebApplication.Domain.Core.Entities;
using System;
using System.Collections.Generic;

/* This file is used to map the "Product" table and to used as a Product entity
 * that inherits from the ProductService entity.
 */
namespace EmprendeUCR_WebApplication.Domain.Core.CoreEntities
{
    public partial class Product : ProductService
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }

        // Foreign entities
        private readonly List<Product_Photos> _product_Photos_List;
        public IReadOnlyCollection<Product_Photos> Product_Photos; 
    }
}
