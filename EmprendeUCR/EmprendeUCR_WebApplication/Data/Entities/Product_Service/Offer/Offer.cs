using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Offer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Offer_ID { get; set; }
        public string Initial_Date { get; set; }
        public string Expire_Date { get; set; }
        public string Offer_Description { get; set; }
        public int Discount { get; set; }
    }
}
