using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Infraestructure.Core;

namespace Ventas.Infraestructure.Models.Productos
{
    public class ProductoUpdateModel :BaseModelUpdate
    {
        public string? CodigoBarra { get; set; }
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int Stock { get; set; }
        public string? UrlImagen { get; set; }
        public string? NombreImagen { get; }
        public decimal Precio { get; set; }
        public bool? EsActivo { get; set; }
    }
}
