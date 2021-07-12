using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class PaymentMethod
    {

        [Key]
        /**
        * @brief setter and getter of the Name of the PaymentMethod
        */
        public string Name { get; set; }

        /**
        * @brief setter and getter of the status of a PaymentMethod
        */
        public bool Status { get; set; }

        //public int Type { get; set; }
    }
    
}
