using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var condicion = compra.Productos.Where(producto => producto.Cantidades == 0).FirstOrDefault();

            if (condicion != null)
            {
                return Ok(compra.Productos.Where(producto => producto.Cantidades == 0));
            }
            else
            {
                return BadRequest("Lista da compra baleira! :D");
            }
        }
    }
}
