﻿using System;
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
        public string Entrepreneur_Email { get; set; }
        public int Category_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Price { get; set; }

    }
}


