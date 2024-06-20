
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Negocios
{
    public class NegocioSaveModel :AuditableSaveBaseModel
    {
        public string? UrlLogo { get; set; }
        public string? NombreLogo { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public decimal? PorcentajeImpuesto { get; set;}
        public string? SymboloModena { get; set; }
    }
}
