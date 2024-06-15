

using Ventas.Domain.Entities;
using Ventas.Domain.Models;

namespace Ventas.Infraestructure.Extentions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Negocio"></param>
    /// <returns></returns>
    public static class NegocioExtentions
    {
        public static NegocioModel ConvertNegocioEntityToNegocioModel(this Negocio negocio) {

            return new NegocioModel()
            {
                Id = negocio.Id,
                Correo=negocio.Correo,
                Direccion=negocio.Direccion,
                Nombre=negocio.Nombre,
                NombreLogo = negocio.NombreLogo,
                NumeroDocumento=negocio.NumeroDocumento,
                PorcentajeImpuesto= negocio.PorcentajeImpuesto,
                SimboloMoneda = negocio.SimboloMoneda,
                Telefono = negocio.Telefono,
                UrlLogo = negocio.UrlLogo

            };
        }

        public static List<NegocioModel> ConvertNegocioEntityToNegocioModel(this List<Negocio> negocio) {
            return negocio.ConvertNegocioEntityToNegocioModel();
        }

    }
}
