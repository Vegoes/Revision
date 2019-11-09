using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaCompra.Controllers
{
    [Route("api/ListaCompra")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly Compra compra;

        public CompraController(Compra compra)
        {
            this.compra = compra;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductoNovo>> Get()
        {
            return Ok(compra.Productos.Where(producto => producto.Cantidades == 0));
        }
    }
}
