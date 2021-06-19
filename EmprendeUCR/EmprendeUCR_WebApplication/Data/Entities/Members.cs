using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
	public class Members
	{
        [Key]
		public string User_Email { get; set; }
        public int Score { get; set; }
        public float Lat { get; set; }
        public float Long {get; set; }
        public string Direction { get; set; }
	}
}