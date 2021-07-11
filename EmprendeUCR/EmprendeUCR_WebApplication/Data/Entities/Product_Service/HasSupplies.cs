using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class HasSupplies
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Offer_ID { get; set; }
        public DateTime Initial_Date { get; set; }
        public DateTime Expire_Date { get; set; }
        public string Offer_Description { get; set; }
        [Required]
        public int Discount { get; set; }
    }
}
