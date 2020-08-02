using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopAPI.Models
{
    public class Tienda
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string FechaApertura { get; set; }
    }
}
