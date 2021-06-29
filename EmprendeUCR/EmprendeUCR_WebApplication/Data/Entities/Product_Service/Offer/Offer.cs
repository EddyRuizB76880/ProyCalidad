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
        public DateTime Initial_Date { get; set; }
        public DateTime Expire_Date { get; set; }
        [Required]
        public string Offer_Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El precio nuevo debe ser mayor a 0.")]
        public int Discount { get; set; }
    }
}
