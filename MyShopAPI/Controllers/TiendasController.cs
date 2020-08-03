using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShopAPI.Data;
using MyShopAPI.Models;

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
        //GET Tiendas/id
        [HttpGet("{id}")]
        public Tienda Get(int id)
        {
            var Tienda = context.Tiendas.FirstOrDefault(p => p.ID == id);
            return Tienda;
        }
        //POST Tiendas
        [HttpPost("add")]
        public IActionResult AgregarTienda(Tienda NuevaTienda)
        {
            var result = context.Tiendas.Add(NuevaTienda);
            return (IActionResult)result;
        }
    }
}
