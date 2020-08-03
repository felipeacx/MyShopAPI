using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShopAPI.Data;
using MyShopAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MyShopAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TiendasController : ControllerBase
    {
        private readonly MyShopDbContext context;

        public TiendasController(MyShopDbContext context)
        {
            this.context = context;
        }

        //GET Tiendas
        [HttpGet]
        public IEnumerable<Tienda> Get()
        {
            return context.Tiendas.ToList();
        }
        //GET Tiendas/id -> Productos
        [HttpGet("{id}")]
        public ProductosdelaTienda Get(int id)
        {
            var ProductosDisponibles = new ProductosdelaTienda();
            var Tienda = context.Tiendas.FirstOrDefault(p => p.ID == id);
            var Productos = context.Productos.ToList();
            ProductosDisponibles.tienda = Tienda;
            for(int i = 0; i < Productos.Count; i++)
            {
                if (Tienda.ID.Equals(Productos[i].Tienda))
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(Productos[i].Imagen);
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    Productos[i].Imagen = base64ImageRepresentation;
                    ProductosDisponibles.AgregarProducto(Productos[i]);
                }
            }
            return ProductosDisponibles;
        }
        //POST Tiendas
        [HttpPost]
        public IActionResult Post([FromBody]Tienda NuevaTienda)
        {
            try
            {
                context.Tiendas.Add(NuevaTienda);
                context.SaveChanges();
                return Ok("Tienda agregada satisfactoriamente.");
            }
            catch
            {
                return BadRequest("ERROR!");
            }
        }
        //PUT Tiendas
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Tienda Tienda)
        {
            try
            {
                context.Entry(Tienda).State = EntityState.Modified;
                context.SaveChanges();
                return Ok("Tienda modificada con éxito.");
            }
            catch
            {
                return BadRequest("ERROR!");
            }
        }
        //DELETE Tiendas
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var Tienda = context.Tiendas.FirstOrDefault(p => p.ID == id);
                if(Tienda != null)
                {
                    context.Tiendas.Remove(Tienda);
                    context.SaveChanges();
                    return Ok("Tienda eliminada con éxito.");
                }
                else
                {
                    return BadRequest("ERROR!");
                }
            }
            catch
            {
                return BadRequest("ERROR!");
            }
        }
    }
}
