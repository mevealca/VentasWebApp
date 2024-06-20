using Microsoft.AspNetCore.Mvc;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Models.Usuarios;


namespace Ventas.Api.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("GetUsuarios")]
        public IActionResult Index()
        {
            var result = this._usuarioRepository.GetUsuarios();

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("GetUsuario")]
        public IActionResult Index([FromQuery] int id)
        {
            var result = this._usuarioRepository.GetUsuario(id);

            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] UsuarioSaveModel usuario)
        {
            this._usuarioRepository.AddUsuario(usuario);

            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] UsuarioUpdateModel usuario)
        {
            this._usuarioRepository.UpdateUsuario(usuario);
            return Ok();
        }

        [HttpPost("Remove")]
        public IActionResult Delete([FromBody] UsuarioRemoveModel usuario)
        {
            this._usuarioRepository.RemoveUsuario(usuario);
            return Ok();
        }
    }
}
