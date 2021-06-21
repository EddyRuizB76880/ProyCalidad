using EmprendeUCR_WebApplication.Domain.Core.Entities;
using System;
using System.Collections.Generic;


namespace EmprendeUCR_WebApplication.Domain.Core.CoreEntities
{
    public partial class Product : ProductService
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        //public int algo { get; set; }
    }
}
