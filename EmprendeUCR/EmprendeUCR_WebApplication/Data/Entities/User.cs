using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class User
    {
		[Key]
		public string Email { get; set; }
		public string Name { get; set; }
		public string F_Last_Name { get; set; }
		public string S_Last_Name { get; set; }
		public DateTime Birth_Date { get; set; }
		public string Province_Name { get; set; }
		public string Canton_Name { get; set; }
		public string District_Name { get; set; }
		public bool Email_Confirmation { get; set; }
    }
}
