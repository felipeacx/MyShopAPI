using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopAPI.Models
{
    public class ProductosdelaTienda
    {
        public Tienda tienda { get; set; }
        public List<Producto> productos { get; set; }
    }
}
