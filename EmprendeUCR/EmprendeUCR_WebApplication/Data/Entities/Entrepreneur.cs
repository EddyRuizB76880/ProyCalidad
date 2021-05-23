using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Entrepreneur
    {
        [Key]
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

    }
}
