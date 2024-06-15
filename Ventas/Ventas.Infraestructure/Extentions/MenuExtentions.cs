
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class MenuExtentions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuModel"></param>
        /// <returns></returns>
        public static MenuModel ConvetMenuEntityToMenuModel(this Menu menuModel) {

            return new MenuModel() {
                Id = menuModel.Id,
                Controlador=menuModel.Controlador,
                Descripcion = menuModel.Descripcion,
                EsActivo = menuModel.EsActivo,
                Icono = menuModel.Icono,
                IdPadre = menuModel.IdMenuPadre,
                Padre = menuModel.Padre.Descripcion,
                PaginaAccion = menuModel.PaginaAccion
            };
        }

        public static List<MenuModel> ConvetMenuEntityToMenuModel(this List<Menu> menuModel) { 
        
            return menuModel.ConvetMenuEntityToMenuModel();
        }
    }
}
