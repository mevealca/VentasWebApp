using Microsoft.Extensions.Logging;
using Ventas.Domain.Entities;
using Ventas.Domain.Models;
using Ventas.Infraestructure.Context;
using Ventas.Infraestructure.Core;
using Ventas.Infraestructure.Execeptions;
using Ventas.Infraestructure.Interfaces;
using Ventas.Infraestructure.Extentions;
using Ventas.Infraestructure.Models.Ventas;

namespace Ventas.Infraestructure.Repositories
{
    public class VentaRepository : BaseRepository<Venta>, IVentaRepository
    {
        private readonly VentasContext _context;
        private readonly ILogger<VentaRepository> _logger;


        public VentaRepository(VentasContext context,ILogger<VentaRepository> logger) : base(context)
        {
            this._context = context;
            this._logger = logger;
        }


        public List<VentaModel> GetVentas()
        {
            List<VentaModel> ventas = new List<VentaModel>();
            try
            {
                ventas = base.GetAll(x => !x.Eliminado.Value).ToList().ConvetVentaEntityToVentaModel();
                return ventas;
            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error consultando las ventas:{ex.Message}", ex.ToString());
                throw new VentaException("No existen ventas...");
            }

   

        }

        public VentaModel GetVenta(int ventaId)
        {

            try
            {
                if (!base.Exists(x => x.Id == ventaId))
                    throw new VentaException("No existe venta");

                var venta = base.Get(ventaId).ConvetVentaEntityToVentaModel();
                return venta;
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error consultando la venta:{ex.Message}", ex.ToString());
                throw new VentaException("No existe venta"); ;
            }
        }

        public void AddVenta(VentasSaveModel venta)
        {
            try
            {
                if (venta is null || string.IsNullOrEmpty(venta.DocumentoCliente))
                    throw new ArgumentNullException("La venta no puede ser nula");

               
                base.Save(venta.ConvertVentaSaveModelToVentaEntity());
                base.SaveChanges();
            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error agregando la venta ${ex.Message}", ex.ToString());
                throw new VentaException("La venta no existe");
            }


        }

        public void RemoveVenta(VentasRemoveModel venta)
        {
            try
            {
                Venta VentaRemove = base.Get(venta.Id);

                if (VentaRemove is null)
                    throw new VentaException("La venta no existe"); ;

                VentaRemove.Eliminado = true;
                VentaRemove.FechaElimino = DateTime.Now;
                VentaRemove.IdUsuarioElimino = venta.IdUsuarioElimino;

                base.Update(VentaRemove);
                base.SaveChanges();

            }
            catch (Exception ex)
            {

                this._logger.LogError($"Error eliminando la venta ${ex.Message}", ex.ToString());
                throw new VentaException("La venta no existe");
            }


        }

        public void UpdateVenta(VentasUpdateModel venta)
        {
            try
            {
                Venta ventaUpdate = base.Get(venta.Id);

                if (ventaUpdate is null)
                    throw new VentaException("La venta no existe"); ;

               
                 ventaUpdate.FechaMod = DateTime.Now;
                 ventaUpdate.IdUsuarioMod = venta.IdUsuarioMod;
                ventaUpdate.DocumentoCliente = venta.DocumentoCliente;
                ventaUpdate.IdTipoDocumentoVenta = venta.IdTipoDocumentoVenta;
                ventaUpdate.ImpuestoTotal = venta.ImpuestoTotal;
                ventaUpdate.NombreCliente = venta.NombreCliente;
                ventaUpdate.NumeroVenta = venta.NumeroVenta;
                ventaUpdate.SubTotal = venta.SubTotal;
                ventaUpdate.IdUsuario = venta.IdUsuario;
                ventaUpdate.Total = venta.Total;
                base.Update(ventaUpdate);
                base.SaveChanges();

            }
            catch (Exception ex)
            {
                this._logger.LogError($"Error actualizando la venta${ex.Message}", ex.ToString());
                throw new ProductoException("La venta no existe");
            }


        }



    }
}
