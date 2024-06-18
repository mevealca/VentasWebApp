
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class RolExtention
    {
        public static RolModel ConvertRolEntityToRolModel(this Rol rol) {
            return new RolModel {
                Id = rol.Id,
                Descripcion = rol.Descripcion,
                EsActivo=rol.EsActivo
            };
        }

        public static List<RolModel> ConvertRolEntityToRolModel(this List<Rol> roles) { 
        
            return roles.ConvertRolEntityToRolModel();
        }
    }
}
