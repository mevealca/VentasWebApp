using Microsoft.AspNetCore.Mvc;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Categorias;

namespace Ventas.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriasRepository;

        public CategoriaController (ICategoriaRepository categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        [HttpGet("GetCategorias")]
        public IActionResult Index()
        {
            var result = this._categoriasRepository.GetCategorias();

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("GetCategoria")]
        public IActionResult Index([FromQuery]int id)
        {
            var result = this._categoriasRepository.GetCategoria(id);

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] CategoriaSaveModel categoria)
        {
            this._categoriasRepository.AddCategoria(categoria);

            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] CategoriaUpdateModel categoria)
        {
            this._categoriasRepository.UpdateCategoria(categoria);
            return Ok();
        }

        [HttpPost("Remove")]
        public IActionResult Delete([FromBody] CategoriaRemoveModel categoria)
        {
            this._categoriasRepository.RemoveCategoria(categoria);
            return Ok();
        }
    }
}
