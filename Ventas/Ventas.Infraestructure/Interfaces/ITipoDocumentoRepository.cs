using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

using Ventas.Infraestructure.Models.TipoDocumentos;
using Ventas.Infraestructure.Models.TipoDocumentoVentas;

namespace Ventas.Infraestructure.Interfaces
{
    public interface ITipoDocumentoRepository :IBaseRepository<TipoDocumentoVenta>
    {
        List<TipoDocumentoVentaModel> GetTipoDocumentoVentas();
        TipoDocumentoVentaModel GetTipoDocumentoVenta(int tipoDocumentoVentaId);
        void AddRol(TipoDocumentoVentaSaveModel tipoDocumentoVenta);
        void UpdateRol(TipoDocumentoVentaUpdateModel tipoDocumentoVenta);
        void RemoveRol(TipoDocumentoVentaRemoveModel tipoDocumentoVenta);
    }
}
