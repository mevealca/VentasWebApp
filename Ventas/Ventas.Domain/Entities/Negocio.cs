
using System.ComponentModel.DataAnnotations.Schema;
using Ventas.Domain.Core;

namespace Ventas.Domain.Entities
{
    [Table("Negocio")]
    public sealed class Negocio : AuditableEntity
    {
        public string? UrlLogo { get; set; }
        public string? NombreLogo { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set;}
        public decimal? PorcentajeImpuesto { get; set; }
        public string? SimboloMoneda { get; set; }

    }
}
