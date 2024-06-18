
namespace Ventas.Infraestructure.Models.Negocios
{
    public class NegocioRemoveModel
    {
        public NegocioRemoveModel()
        {
            this.FechaElimino = DateTime.Now;
            this.Eliminado = true;
        }
        public string? UrlLogo { get; set; }
        public string? NombreLogo { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public decimal? PorcentajeImpuesto { get; set; }
        public string? SymboloModena { get; set; }
        public DateTime? FechaElimino { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public bool? Eliminado { get; set; }
    }
}
