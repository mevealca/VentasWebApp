using Microsoft.AspNetCore.Mvc;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Productos;


namespace Ventas.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet("GetProductos")]
        public IActionResult Index()
        {
            var result = this._productoRepository.GetProductos();

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("GetProducto")]
        public IActionResult Index([FromQuery] int id)
        {
            var result = this._productoRepository.GetProducto(id);

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] ProductoSaveModel producto)
        {
            this._productoRepository.AddProducto(producto);

            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] ProductoUpdateModel producto)
        {
            this._productoRepository.UpdateProducto(producto);
            return Ok();
        }

        [HttpPost("Remove")]
        public IActionResult Delete([FromBody] ProductoRemoveModel producto)
        {
            this._productoRepository.RemoveProducto(producto);
            return Ok();
        }
    }
}
