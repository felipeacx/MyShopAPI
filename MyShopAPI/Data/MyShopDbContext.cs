using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyShopAPI.Models;

namespace MyShopAPI.Data
{
    public class MyShopDbContext : DbContext
    {
        public MyShopDbContext (DbContextOptions<MyShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Table> Logs { get; set; }

    }
}
