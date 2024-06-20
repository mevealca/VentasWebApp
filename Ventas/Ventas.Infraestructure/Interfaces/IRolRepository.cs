using Ventas.Domain.Core;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Models.Roles;

namespace Ventas.Infraestructure.Interfaces
{
    public interface IRolRepository : IBaseRepository<Rol>
    {
        List<RolModel> GetRoles();
        RolModel GetRol(int rolId);
        void AddRol(RolSaveModel rol);
        void UpdateRol(RolUpdateModel rol);
        void RemoveRol(RolRemoveModel rol);
    }
}
