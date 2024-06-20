

using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.TipoDocumentoVentas
{
    public class TipoDocumentoVentaUpdateModel : BaseModelUpdate
    {
        public string? Descripcion { get; set; }
        public bool? EsActivo { get; set; }
    }
}
