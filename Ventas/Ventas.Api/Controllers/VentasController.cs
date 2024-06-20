using Microsoft.AspNetCore.Mvc;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Ventas;

namespace Ventas.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentaRepository _ventaRepository;
        public VentasController(IVentaRepository ventaRepository) {
            _ventaRepository = ventaRepository;
        }

        [HttpGet("GetVentas")]
        public IActionResult Index()
        {
            var result = this._ventaRepository.GetVentas();

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("GetVenta")]
        public IActionResult Index([FromQuery] int id)
        {
            var result = this._ventaRepository.GetVenta(id);

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] VentasSaveModel venta)
        {
            this._ventaRepository.AddVenta(venta);

            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] VentasUpdateModel venta)
        {
            this._ventaRepository.UpdateVenta(venta);
            return Ok();
        }

        [HttpPost("Remove")]
        public IActionResult Delete([FromBody] VentasRemoveModel venta)
        {
            this._ventaRepository.RemoveVenta(venta);
            return Ok();
        }
    }
}
