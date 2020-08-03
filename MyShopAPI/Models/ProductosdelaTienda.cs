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
        public string AgregarProducto(Producto producto)
        {
            if(producto != null)
            {
                this.productos.Add(producto);
                return "Producto agregado con exito!.";
            }
            else
            {
                return "ERROR!";
            }
        }
    }
}
