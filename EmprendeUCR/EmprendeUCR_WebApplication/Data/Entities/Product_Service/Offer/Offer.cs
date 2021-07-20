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
        public string Offer_Description { get; set; }
        [Required]
        public int Discount { get; set; }

        public bool isTypeOfferCombo(List<Is_Offer> relatedIs_Offers)
        {
            // True = Combo
            // False = descuento
            return relatedIs_Offers.Count > 1;
        }
    }
}
