using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Usuarios;
using Ventas.Infraestructure.Models.Ventas;

namespace Ventas.Infraestructure.Interfaces
{
    public interface IVentaRepository :IBaseRepository<Venta>
    {
        List<VentaModel> GetVentas();
        VentaModel GetVenta(int ventaId);
        void AddVenta(VentasSaveModel venta);
        void UpdateVenta(VentasUpdateModel venta);
        void RemoveVenta(VentasRemoveModel venta);
    }
}
