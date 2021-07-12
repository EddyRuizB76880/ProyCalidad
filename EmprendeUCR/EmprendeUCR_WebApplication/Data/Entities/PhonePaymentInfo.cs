using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class PhonePaymentInfo
    {
        [Key]
        /**
        * @brief setter and getter of the Name of the PaymentMethod
        */
        public int PhoneNumber { get; set; }

        public string NamePaymentMethod { get; set; }

        public int PaymentInfoID  { get; set; }
    }
}