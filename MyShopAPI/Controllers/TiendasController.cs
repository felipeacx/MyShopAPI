using System;
using System.Collections;
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
            CreateLog("GET");
            context.SaveChanges();
            return context.Tiendas.ToList();
        }
        //GET Tiendas/id -> Productos
        [HttpGet("{id}")]
        public ProductosdelaTienda Get(int id)
        {
            var Tienda = context.Tiendas.FirstOrDefault(p => p.ID == id);
            if(Tienda != null)
            {
                CreateLog("GET/id");
                context.SaveChanges();
                var ProductosDisponibles = new ProductosdelaTienda();
                var Productos = context.Productos.ToList();
                ProductosDisponibles.tienda = Tienda;
                var products = new List<Producto>();
                for (int i = 0; i < Productos.Count; i++)
                {
                    if (Tienda.ID == Productos[i].IDTienda)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(Productos[i].Imagen+".jpg");
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        Productos[i].Imagen = base64ImageRepresentation;
                        products.Add(Productos[i]);
                    }
                }
                ProductosDisponibles.productos = products;
                return ProductosDisponibles;
            }
            else
            {
                return null;
            }
            
        }
        //POST Tiendas
        [HttpPost]
        public IActionResult Post([FromBody]Tienda NuevaTienda)
        {
            try
            {
                CreateLog("POST");
                context.SaveChanges();
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
                CreateLog("PUT/id");
                context.SaveChanges();
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
                CreateLog("Delete/id");
                context.SaveChanges();
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

        public void CreateLog(string TipoPeticion)
        {
            try
            {
                context.Database.OpenConnection();
                _ = context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Logs ON;");
                var Log = new Table();
                Log.Id = context.Logs.Count()+1;
                Log.Log = "Petición " + TipoPeticion + " a las: " + DateTime.Now.ToString();
                context.Logs.Add(Log);
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
