using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Shopping_Cart_Has
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Email { get; set; }
        public int Code_ID { get; set; }
        public string Entrepreneur_Email { get; set; }
        public int Category_ID { get; set; }
    }
}
