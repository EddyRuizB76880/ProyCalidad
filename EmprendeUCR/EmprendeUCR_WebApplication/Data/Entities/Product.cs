using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Product
    {
        [Key]
        public int Code_ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
