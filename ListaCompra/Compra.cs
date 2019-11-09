using Aplicacion;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaCompra
{
    public class Compra : DbContext
    {
        public DbSet<ProductoNovo> Productos { get; set; }
        public Compra(DbContextOptions options) : base(options)
        {
        }
    }
}
