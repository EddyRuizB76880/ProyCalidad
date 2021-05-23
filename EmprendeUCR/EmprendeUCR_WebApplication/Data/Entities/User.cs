using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class User
    {
        [Key]

        public string Email { get; set; }
        public string Name { get; set; }
        public string F_Last_Name { get; set; }
        public string S_Last_Name { get; set; }
        public string Photo { get; set; }
        public string Birth_Date { get; set; }
        public string Province_Name { get; set; }
        public string Canton_Name { get; set; }
        public string District_Name { get; set; }
    }
}
