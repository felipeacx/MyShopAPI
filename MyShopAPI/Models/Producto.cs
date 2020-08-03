using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopAPI.Models
{
    public class Producto
    {
        [Key]
        [Required]
        public int SKU { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Valor { get; set; }
        [Required]
        [ForeignKey("IDTienda")]
        public virtual Tienda Tienda { get; set; }
        [Required]
        public string Imagen { get; set; }
    }
}
