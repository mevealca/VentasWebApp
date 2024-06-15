
using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    public static class TipoDocumentoVentaExtentions
    {
        public static TipoDocumentoVentaModel ConvertTipoDocumentoVentaEntityToTipoDocumentoVentaModel(this TipoDocumentoVenta tipoDocumentoVenta) {

            return new TipoDocumentoVentaModel() { 
                Id=tipoDocumentoVenta.Id,
                Descripcion=tipoDocumentoVenta.Descripcion,
                EsActivo=tipoDocumentoVenta.EsActivo
            };
        
        }

        public static List<TipoDocumentoVentaModel> ConvertTipoDocumentoVentaEntityToTipoDocumentoVentaModel(this List<TipoDocumentoVenta> tipoDocumentoVenta) { 
            return tipoDocumentoVenta.ConvertTipoDocumentoVentaEntityToTipoDocumentoVentaModel();   
        }


    }
}
