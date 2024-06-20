using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Negocios;
using Ventas.Infraestructure.Models.Productos;

namespace Ventas.Infraestructure.Interfaces
{
    public interface INegocioRepository : IBaseRepository<Negocio>
    {
        List<NegocioModel> GetNegocios();
        NegocioModel GetNegocio(int negocioId);
        void AddNegocio(NegocioSaveModel negocio);
        void UpdateNegocio(NegocioUpdateModel negocio);
        void RemoveNegocio(NegocioRemoveModel negocio);
    }
}
